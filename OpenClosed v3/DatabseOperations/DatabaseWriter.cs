using System.Data.SqlClient;

namespace OpenClosed_v3.DatabseOperations
{
    public class DatabaseWriter : Interfaces.IWriter
    {
        public void Print(string message)
        {
            SqlCommand printResult = new SqlCommand();
            int result;
            string resultMessage;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=STUDENT04-PC\\SQLEXPRESS;Database=TestDB;Trusted_Connection=true";
            connection.Open();

            if (int.TryParse(message.Substring(message.LastIndexOf(" ") + 1), out result)) // good operation
            {
                resultMessage = "Insert into Result (Value) Values ( @0)";
            }
            else // invalid operation (error message)
            {
                resultMessage = "Insert into Result (ErrorMessage) Values ( @0)";
            }
            printResult = new SqlCommand(resultMessage, connection);
            printResult.Parameters.Add(new SqlParameter("@0", message));
            printResult.Connection = connection;
            printResult.ExecuteNonQuery();

            // get results count
            int resultsCount = 0;
            SqlCommand getResultsCount = new SqlCommand("Select Count(*) from Result", connection);
            SqlDataReader reader = getResultsCount.ExecuteReader();
            if (reader.Read())
            {
                resultsCount = int.Parse(reader[0].ToString());
                reader.Close();
            }

            printResult = new SqlCommand(string.Format("UPDATE Operation SET ResultID = {0} WHERE OperationID  = {0}", resultsCount));
            printResult.Connection = connection;
            printResult.ExecuteNonQuery();

            connection.Close();
        }
    }
}
