using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OpenClosed_v3.DatabseOperations
{
    public class DatabaseReader : Interfaces.IReader
    {
        private Queue<Calculation> calculations;

        public DatabaseReader()
        {
            calculations = new Queue<Calculation>();
            string firstNumber = "";
            string secondNumber = "";
            string sign = "";

            SqlConnection connection = new SqlConnection();

            // move to config
            connection.ConnectionString = "Server=STUDENT04-PC\\SQLEXPRESS;Database=TestDB;Trusted_Connection=true";
            connection.Open();

            SqlCommand getCalculations = new SqlCommand(@"EXECUTE dbo.GetCalculations", connection);

            //read data 0 - operationID, 1 - firstOperand, 2 - secondOperand, 3 - sign
            SqlDataReader reader = getCalculations.ExecuteReader();

            while(reader.Read())
            {
                firstNumber = reader[1].ToString();
                secondNumber = reader[2].ToString();
                sign = reader[3].ToString();

                calculations.Enqueue(new Calculation(firstNumber, sign, secondNumber));
            }
            reader.Close();
            connection.Close();
        }

        public static void ReadTable()
        {
            // get calculation from DB
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=STUDENT04-PC\\SQLEXPRESS;Database=TestDB;Trusted_Connection=true";
            connection.Open();

            SqlCommand getCalculations = new SqlCommand("EXECUTE dbo.ReadCalculations", connection);

            //read data 0 - operationID, 1 - firstOperand, 2 - secondOperand, 3 - sign
            SqlDataReader reader = getCalculations.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4] + "\t" + reader[5]);
            }
            connection.Close();
        }

        public Calculation ReadCalculation()
        {
            if (calculations.Count != 0)
            {
                return calculations.Dequeue();
            }
            Environment.Exit(0); // brutal & eficient :D
            return new Calculation(null, null, null);
        }
    }
}
