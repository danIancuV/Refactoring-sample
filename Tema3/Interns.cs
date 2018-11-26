using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Interns
    {
        public int Id { get; }
        public string FirstName { get;  set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public Interns(int id, string firstName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
