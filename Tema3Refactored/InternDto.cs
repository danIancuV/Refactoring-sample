using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class InternDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public InternDto(int id, string firstName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Intern MapTo(InternDto internDto)
        {
            Intern intern = new Intern(internDto.Id, internDto.FirstName, internDto.LastName, internDto.PhoneNumber);
            return intern;
        }
        public InternDto MapTo(Intern intern)
        {
            InternDto internDto = new InternDto(intern.Id, intern.FirstName, intern.LastName, intern.PhoneNumber);
            return internDto;
        }
    }
}
