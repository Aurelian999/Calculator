using System.Configuration;
using System.IO;

namespace OpenClosed_v3.CSVOperations
{
    public class CSVWriter : Interfaces.IWriter
    {
        public void Print(string message)
        {
            StreamWriter sw = System.IO.File.AppendText(@ConfigurationManager.AppSettings["results.csv"]);
            sw.WriteLine(message);
            sw.Dispose();
        }
    }
}
