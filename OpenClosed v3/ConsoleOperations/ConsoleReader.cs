using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed_v3.Interfaces;

namespace OpenClosed_v3.ConsoleOperations
{
    public class ConsoleReader : Interfaces.IReader
    {
        public Calculation ReadCalculation()
        {
            Console.WriteLine("First number: ");
            string firstNumber  = Console.ReadLine();

            Console.WriteLine("Operation: ");
            string operation = Console.ReadLine();

            Console.WriteLine("Second number: ");
            string secondNumber = Console.ReadLine();

            Calculation calculation = new Calculation(firstNumber, operation, secondNumber);

            return calculation;
        }
    }
}
