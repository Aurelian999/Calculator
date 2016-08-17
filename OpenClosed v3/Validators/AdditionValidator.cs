using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed_v3.Interfaces;

namespace OpenClosed_v3.Validators
{
    public class AdditionValidator : Interfaces.IValidator
    {
        public bool Validate(ICalculation calculation)
        {
            return NumberValidator.Validate(calculation.GetFirstNumber()) && NumberValidator.Validate(calculation.GetSecondNumber()) && SignValidator.Validate(calculation.GetSign());
        }
    }
}
