using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class InternsDeletion
    {
        readonly InternsListPrinter _internsListPrinter = new InternsListPrinter();
        Validator validator = new Validator();
        public bool Delete(List<Intern> deleteList, int deleteId)
        {
            _internsListPrinter.Print(deleteList);
            bool isDeletedIntern;          
            if (deleteList.Any(i => i.Id == deleteId))
            {
                deleteList.Remove(deleteList.Single(r => r.Id == deleteId));               
                _internsListPrinter.Print(deleteList);
                isDeletedIntern = true;
            }
            else
            {
                isDeletedIntern = false;
            }
            return isDeletedIntern;
        }
    }
}
