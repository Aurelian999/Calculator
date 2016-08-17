using System.Collections.Generic;
using OpenClosed_v3.Operations;

namespace OpenClosed_v3
{
    public class OperationsCreator
    {
        int result;
        delegate int CreateOperation(int a, int b);

        private Dictionary<char, CreateOperation> a = new Dictionary<char, CreateOperation>()
        {
            { '+', new Add().Execute },
            { '-', new Substract().Execute },
            { '*', new Multiply().Execute },
            { '/', new Divide().Execute }
        }; 

        public OperationsCreator(int firstNumber, int secondNumber, char sign)
        {
            result = a[sign].Invoke(firstNumber, secondNumber);
        }

        public int ReturnResult()
        {
            return result;  // returns result
        }
        

    }
}
