using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class InternsCreator
    {
        public Intern Create(int id, string firstName, string lastName, string phoneNumber)
        {           
            Intern intern = new Intern(id, firstName, lastName, phoneNumber);
            return intern;
        }
    }
}
