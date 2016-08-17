using OpenClosed_v3.Interfaces;
using System;
using System.Data.SqlClient;

namespace OpenClosed_v3.DatabseOperations
{
    public class DatabaseAddCalculation
    {
        public static void InsertCalculationInDB(ICalculation calculation)
        {
            int operandsCount = 0;
            int operatorID = 0;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=STUDENT04-PC\\SQLEXPRESS;Database=TestDB;Trusted_Connection=true";
            
            SqlCommand insertOperands = new SqlCommand("Insert into Operand (Value) Values ( @0), (@1)", connection);
            insertOperands.Parameters.Add(new SqlParameter("@0", calculation.GetFirstNumber()));  
            insertOperands.Parameters.Add(new SqlParameter("@1", calculation.GetSecondNumber()));  
            insertOperands.Connection = connection;
            
            connection.Open();
            
            insertOperands.ExecuteNonQuery(); // insert operands            
            
            SqlCommand getOperandsCount = new SqlCommand("Select Count(OperandID) from Operand", connection);
            SqlDataReader dataReader = getOperandsCount.ExecuteReader();
            if(dataReader.Read())
            {
                operandsCount = int.Parse(dataReader[0].ToString());
            }
            dataReader.Close();

            SqlCommand getOperatorsCount = new SqlCommand("Select OperatorID from Operator where Value = '" + char.Parse(calculation.GetSign()) + "'", connection);
            dataReader = getOperatorsCount.ExecuteReader();
            if (dataReader.Read())
            {
                operatorID = int.Parse(dataReader[0].ToString());
            }
            dataReader.Close();
            
            SqlCommand insertCalculation = new SqlCommand("Insert into Operation (LeftOperandID, RightOperandId, OperatorID) Values (@0, @1, @2)", connection);
            insertCalculation.Parameters.Add(new SqlParameter("@0", operandsCount - 1)); 
            insertCalculation.Parameters.Add(new SqlParameter("@1", operandsCount)); 
            insertCalculation.Parameters.Add(new SqlParameter("@2", operatorID));
            insertCalculation.Connection = connection;
            insertCalculation.ExecuteNonQuery();

            connection.Close();
        }
    }
}
