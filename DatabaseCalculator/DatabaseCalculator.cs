using OpenClosed_v3;
using OpenClosed_v3.DatabseOperations;
using System;

namespace DatabaseCalculator
{
    class DatabaseCalculator
    {
        static void Main(string[] args)
        {
            
            var x = new Calculator(new DatabaseReader(), new DatabaseWriter());
            x.ExecuteCalculator();
            


            //DatabaseReader.ReadTable();

            //DatabaseReader reader = new DatabaseReader();
            //ICalculation calc = reader.ReadCalculation();



            /*
            DatabaseAddCalculation.InsertCalculationInDB(new Calculation("159", "*", "maimute spatiale"));
            DatabaseAddCalculation.InsertCalculationInDB(new Calculation("755", "/", "5"));
            */

            Console.ReadKey();

        }
    }
}
