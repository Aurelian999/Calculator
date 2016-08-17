using System.Configuration;
using System.IO;

namespace OpenClosed_v3.FileOperations
{
    public class FileWriter : Interfaces.IWriter
    {
        public void Print(string message)
        {
            StreamWriter sw = System.IO.File.AppendText(@ConfigurationManager.AppSettings["results.txt"]);
            sw.WriteLine(message);
            sw.Dispose();
        }
    }
}
