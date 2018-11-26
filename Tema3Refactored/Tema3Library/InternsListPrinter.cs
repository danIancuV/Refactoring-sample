using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class InternsListPrinter
    {
        public void Print(List<Intern> printList)
        {
            Console.WriteLine("==Intern List==");
            foreach (Intern printIntern in printList)
            {
                Console.WriteLine(">" + printIntern.Id + "< " + printIntern.FirstName + " " + printIntern.LastName + " " + printIntern.PhoneNumber);
            }
            Console.WriteLine("===============");
            Console.WriteLine();
        }
    }
}
