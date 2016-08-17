using OpenClosed_v3;
using OpenClosed_v3.FileOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCalculator
{
    class FileCalculator
    {
        static void Main(string[] args)
        {
            var x = new Calculator(new FileReader(), new FileWriter());
            x.ExecuteCalculator();
        }
    }
}
