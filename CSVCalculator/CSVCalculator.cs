using OpenClosed_v3;
using OpenClosed_v3.CSVOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVCalculator
{
    class CSVCalculator
    {
        static void Main(string[] args)
        {
            var x = new Calculator(new CSVReader(), new CSVWriter());
            x.ExecuteCalculator();
        }
    }
}
