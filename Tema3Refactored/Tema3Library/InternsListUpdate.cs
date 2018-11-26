using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class InternsListUpdate
    {
        private readonly InternsCreator _internsCreator = new InternsCreator();
        private readonly InternsListPrinter _internsListPrinter = new InternsListPrinter();
        
        public bool AddNewIntern(List<Intern> updatelist, Intern intern)
        {
            updatelist.Add(_internsCreator.Create(intern.Id, intern.FirstName, intern.LastName, intern.PhoneNumber));          
            return true;           
        }

        public bool UpdateIntern(List<Intern> updatelist, Intern intern)
        {
            _internsListPrinter.Print(updatelist);
            bool isUpdatedIntern;          
            if (updatelist.Any(i => i.Id == intern.Id))
            {
                Intern uptdobj = updatelist.Single(r => r.Id == intern.Id);
                uptdobj.FirstName = intern.FirstName;
                uptdobj.LastName = intern.LastName;
                uptdobj.PhoneNumber = intern.PhoneNumber;
                _internsListPrinter.Print(updatelist);
                isUpdatedIntern = true;
            }
            else
            {
                isUpdatedIntern = false;
            }
            return isUpdatedIntern;
        }
    }
}
