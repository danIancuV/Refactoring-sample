using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Program
    {
        public static Interns NewIntern()
        {
            Console.WriteLine("Input intern id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input Phone number: ");
            string phoneNumber = Console.ReadLine();

            Interns intern = new Interns(id, firstName, lastName, phoneNumber);
            return intern;
        }

        public static void PrintList(List<Interns> printList)
        {
            Console.WriteLine("==Intern List==");
            foreach (Interns printIntern in printList)
            {
                Console.WriteLine(">" + printIntern.Id + "< " + printIntern.FirstName + " " + printIntern.LastName + " " + printIntern.PhoneNumber);
            }
            Console.WriteLine("===============");
            Console.WriteLine();
        }

        public static void DeleteItem(List<Interns> deleteList)
        {
            PrintList(deleteList);
            Console.WriteLine("Which intern do you want to delet?(Input intern ID)");
            int idDeleted = Convert.ToInt32(Console.ReadLine());
            if (IsValid(deleteList, idDeleted))
            {
                deleteList.Remove(deleteList.Single(r => r.Id == idDeleted));
                Console.WriteLine("Deleted");
                PrintList(deleteList);
            }
            else
            {
                Console.WriteLine("ERROR: Intern does not exist");
            }
            Menu();
        }

        public static void UpdateItem(List<Interns> updatelist)
        {
            PrintList(updatelist);
            Console.WriteLine("Which intern do you want to update?(Input intern ID)");
            int isUpdated = Convert.ToInt32(Console.ReadLine());
            if (IsValid(updatelist, isUpdated))
            {
                Interns uptdobj = updatelist.Single(r => r.Id == isUpdated);
                Console.WriteLine("Input First name: ");
                uptdobj.FirstName = Console.ReadLine();
                Console.WriteLine("Input Last name: ");
                uptdobj.LastName = Console.ReadLine();
                Console.WriteLine("Input Phone number: ");
                uptdobj.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Intern updated successfully");
                Console.WriteLine(" ");

                PrintList(updatelist);
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("ERROR: Intern does not exist");
            }
            Menu();

        }

        public static void AddNewIntern(List<Interns> updatelist)
        {
            updatelist.Add(NewIntern());
            Console.WriteLine(" ");
            Console.WriteLine("Intern added successfully");
            Console.WriteLine(" ");
            Menu();
        }


        public static void Menu()
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

        //used for Delete and Update. Checks if id from input is an id of an intern
        public static bool IsValid(List<Interns> checkValidList, int checkId)
        {
            bool isIdValid = false;
            foreach (Interns checkValidIntern in checkValidList)
            {
                isIdValid = isIdValid ^ (checkValidIntern.Id == checkId);
            }
            return isIdValid;
        }


        static void Main(string[] args)
        {
            List<Interns> internList = new List<Interns>();
            Menu();
            string input = Console.ReadLine();
            //used to check if Menu inputs are valid
            String[] validOptions = { "1", "2", "3", "4", "X" };

            while(input != "X")
            {
                if (input == "1")
                {
                    AddNewIntern(internList);
                    input = Console.ReadLine();
                }

                if (input == "2")
                {
                    UpdateItem(internList);
                    input = Console.ReadLine();

                }

                if (input == "3")
                {
                    DeleteItem(internList);
                    input = Console.ReadLine();
                }

                if (input == "4")
                {
                    PrintList(internList);
                    Menu();
                    input = Console.ReadLine();
                }

                if (validOptions.Contains(input) == false)
                {
                    Console.WriteLine("Wrong Option, Try again");
                    Menu();
                    input = Console.ReadLine();
                }
            }
        }
    }
}
