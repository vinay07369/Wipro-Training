using System;
using System.Data.SqlClient;

class OrderCustomerJoin
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // SQL query to select OrderID, CompanyName, and OrderDate from the Orders and Customers tables
        string sqlquery = "SELECT o.OrderID, c.CompanyName, o.OrderDate FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID ";

        // Create a connection to the database and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create a SqlCommand to execute the SQL query
            SqlCommand command = new SqlCommand(sqlquery, connection);

            try
            {
                // Open the connection and execute the command
                connection.Open();

                // Execute the command and retrieve the data using SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Display the results in a formatted manner
                Console.WriteLine("OrderID".PadRight(10) + "CompanyName".PadRight(40) + "OrderDate");
                Console.WriteLine(new string('-', 80));


                // Read through the data returned by the SqlDataReader
                while (reader.Read())
                {
                    string orderId = reader["OrderID"]?.ToString() ?? string.Empty;

                    string companyName = reader["CompanyName"]?.ToString() ?? string.Empty;

                    string orderDate = reader["OrderDate"]?.ToString() ?? string.Empty;

                    Console.WriteLine(orderId.PadRight(10) + companyName.PadRight(40) + orderDate);

                }
                reader.Close();
            }

            // Handle exceptions that may occur during database operations
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
