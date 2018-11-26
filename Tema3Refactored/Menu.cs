using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    public class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Add an intern");
            Console.WriteLine("2. Update an intern");
            Console.WriteLine("3. Delete an intern");
            Console.WriteLine("4. Show all interns");
            Console.WriteLine("X. Exit");
            Console.Write("Choose an option: ");
            Console.WriteLine(" ");
        }

        public static void PerformAction()
        {
            InternsListUpdate internsListUpdate = new InternsListUpdate();
            InternsDeletion internsDeletion = new InternsDeletion();
            InternsListPrinter internsListPrinter = new InternsListPrinter();
            Validator validator = new Validator();

            List<Intern> internList = new List<Intern>();

            string input = Console.ReadLine();

            while (input != "X")
            {
                if (input == "1")
                {
                    InternDto internDto = FetchInternData();
                    bool isAdded = internsListUpdate.AddNewIntern(internList, internDto.MapTo(internDto));
                    if (isAdded)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Intern added successfully");
                        Console.WriteLine(" ");
                        Menu.ShowMenu();
                        input = Console.ReadLine();
                    }
                }

                if (input == "2")
                {
                    InternDto internDto = FetchInternData();
                    bool isUpdated = internsListUpdate.UpdateIntern(internList, internDto.MapTo(internDto));

                    if (isUpdated)
                    {
                        Console.WriteLine("Intern updated successfully");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("ERROR: Intern does not exist");
                    }
                    Menu.ShowMenu();
                    input = Console.ReadLine();
                }

                if (input == "3")
                {
                    Console.WriteLine("Which intern do you want to delet?(Input intern ID)");
                    int idDeleted = Convert.ToInt32(Console.ReadLine());
                    bool isDeleted = internsDeletion.Delete(internList, idDeleted);
                    Console.WriteLine(isDeleted ? "Deleted" : "ERROR: Intern does not exist");
                    Menu.ShowMenu();
                    input = Console.ReadLine();
                }

                if (input == "4")
                {
                    internsListPrinter.Print(internList);
                    ShowMenu();
                    input = Console.ReadLine();
                }

                if (validator.IsValidMenuOption(input))
                {
                    continue;
                }

                Console.WriteLine("Wrong Option, Try again");
                ShowMenu();
                input = Console.ReadLine();

            }
        }

        private static InternDto FetchInternData()
        {
            
            try
            {
                Console.WriteLine("Input intern id ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input First name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Input Last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Input Phone number: ");
                string phoneNumber = Console.ReadLine();

                InternDto internDto = new InternDto(id, firstName, lastName, phoneNumber);

                return internDto;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }

}
