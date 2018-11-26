using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Refactored
{
    class Validator
    {
        //used to check if Menu inputs are valid
        public bool IsValidMenuOption(string input)
        {
            String[] validOptions = {"1", "2", "3", "4", "X"};
            bool isValidOption = validOptions.Contains(input);
            return isValidOption;           
        }
    }
}
    


        



