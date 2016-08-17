using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3.Interfaces
{
    public interface ICalculation
    {
        string GetFirstNumber();
        string GetSecondNumber();
        string GetSign();
        int Result();  // which one would fkin work???
        string ResultMessage();
        bool IsValid();
    }
}
