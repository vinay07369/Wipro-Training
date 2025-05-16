using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // 1.Initialize the connection
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            // 2.Open the connection

            connection.Open();

            // 3.Pass the connection to the command object

            SqlCommand cmd = new SqlCommand("Select * From Customers ", connection);

            // 4.Use the connection

            //Get query results
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        { 
            //Close the Reader

            if (rdr != null)
            {
                rdr.Close();
            }

            //5. Close the connection
            if (connection != null)
            {
                connection.Close();
            }                              
        }
    }
}
