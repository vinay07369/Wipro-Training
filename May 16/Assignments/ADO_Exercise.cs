using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // 1.Initialize the connection
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true");

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

            Console.WriteLine("ContactName              City                CompanyName");
            Console.WriteLine("------------             ------------        ------------");

            while (rdr.Read())
            {
                string ContactName = rdr[2].ToString();

                string City = rdr[5].ToString();

                string CompanyName = rdr[1].ToString();

                Console.Write("{0,-25}", ContactName);
                Console.Write("{0,-20}", City);
                Console.Write("{0,-25}", CompanyName);
                Console.WriteLine();
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

