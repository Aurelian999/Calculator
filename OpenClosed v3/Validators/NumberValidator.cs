using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3.Validators
{
    public static class NumberValidator 
    {
        public static bool Validate(string input)
        {
            try
            {
                int firstNumber = int.Parse(input);
                return true;
            }
            catch (Exception invalidOperandException)
            {
                return false;
            }
        }
    }
}
