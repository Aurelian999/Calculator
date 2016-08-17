using OpenClosed_v3.Interfaces;
using OpenClosed_v3.Validators;
using System.Collections.Generic;

namespace OpenClosed_v3
{
    public class Validator
    {
        delegate bool CreateValidator(ICalculation calculation);

        private static Dictionary<char, CreateValidator> validatorDictionary = new Dictionary<char, CreateValidator>()
        {
            { '+', new AdditionValidator().Validate },
            { '-', new SubstractionValidator().Validate },
            { '*', new MultiplicationValidator().Validate },
            { '/', new DivisionValidator().Validate }
        };

        public static bool ValidatorDictionary(char sign, ICalculation calculation)
        {
            try
            {
                return validatorDictionary[sign].Invoke(calculation);
            }
            catch (System.Collections.Generic.KeyNotFoundException ex)
            {
                return false;
            }
        }
    }
}
