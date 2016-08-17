using OpenClosed_v3;
using OpenClosed_v3.ConsoleOperations;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class ConsoleCalculator
    {
        static void Main(string[] args)
        {
            var x = new Calculator(new ConsoleReader(), new ConsoleWriter());
            x.ExecuteCalculator();
        }
    }
}
