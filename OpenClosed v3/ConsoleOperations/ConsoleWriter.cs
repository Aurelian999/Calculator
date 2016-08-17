using System;

namespace OpenClosed_v3.ConsoleOperations
{
    public class ConsoleWriter : Interfaces.IWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
