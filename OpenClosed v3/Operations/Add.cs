using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3.Operations
{
    public class Add : Interfaces.IOperation
    {
        public int Execute(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
