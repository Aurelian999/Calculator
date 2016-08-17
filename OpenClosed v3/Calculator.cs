using OpenClosed_v3.Interfaces;

namespace OpenClosed_v3
{
    public class Calculator
    {
        private IReader _reader;
        private IWriter _writer;

        public Calculator(IReader reader, IWriter writer)
        {
            this._reader = reader;
            this._writer = writer;
        }

        public void ExecuteCalculator()
        {
            while(true)
            {
                ICalculation calculation = _reader.ReadCalculation();
                _writer.Print(calculation.ResultMessage());
            }
        }
    }
}
