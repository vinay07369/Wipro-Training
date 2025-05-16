using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" 
            + "Integrated Security=true";

        //Provide the query string with a parameter placeholder.
        string querystring = "SELECT ProductID, UnitPrice, ProductName from dbo.products " 
                + "WHERE UnitPrice > @pricePoint "
                + "ORDER BY UnitPrice DESC;";

        //Specify the parameter value
        int paramValue = 5;

        //create and open the connection in a using block.This
        //ensures that all resources will be closed and disposed 
        //when the code exits
        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            //Create the command and paramter object
            SqlCommand command = new SqlCommand(querystring, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}