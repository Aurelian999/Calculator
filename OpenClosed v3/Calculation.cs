using OpenClosed_v3.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3
{
    public class Calculation : Interfaces.ICalculation
    {
        public string _firstNumber;
        public string _secondNumber;
        public string _operation;

        public Calculation(string firstNumber, string operation, string secondNumber)
        {
            this._firstNumber = firstNumber;
            this._secondNumber = secondNumber;
            this._operation = operation;
        }
        public bool IsValid()
        {
            return Validator.ValidatorDictionary(char.Parse(this._operation), this);
        }

        public int Result()
        {
            return new OperationsCreator(int.Parse(_firstNumber), int.Parse(_secondNumber), char.Parse(_operation)).ReturnResult();
        }

        public string ResultMessage()
        {
            if(this.IsValid())
            {
                return string.Format("{0} {1} {2} = {3}", this._firstNumber, this._operation, this._secondNumber, Result());
            }
            else
            {
                return "Invalid Operation: " + string.Format("{0} {1} {2}", this._firstNumber, this._operation, this._secondNumber);
            }
        }

        public string GetFirstNumber()
        {
            return this._firstNumber;
        }

        public string GetSecondNumber()
        {
            return this._secondNumber;
        }

        public string GetSign()
        {
            return this._operation;
        }
    }
}
