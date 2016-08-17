using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3.FileOperations
{
    public class FileReader : Interfaces.IReader
    {
        Queue<string> calculationsQueue = new Queue<string>(File.ReadAllLines(@ConfigurationManager.AppSettings["worksheet.txt"]));

        public Calculation ReadCalculation()
        {
            if(calculationsQueue.Count != 0)
            {
                string[] values = calculationsQueue.Dequeue().Split(',');  // empty q --> System.InvalidOperationException
                return new Calculation(values[0], values[2], values[1]);
            }

            Environment.Exit(0); // brutal & eficient :D
            return new Calculation(null, null, null);
        }
    }
}
