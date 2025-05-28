using System;
using System.Data.SqlClient;

class ListCustomers
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // SQL query to select CustomerID, CompanyName, and Country from the Customers table
        string sqlquery = "SELECT CustomerID, CompanyName, Country FROM Customers";

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

                Console.WriteLine("CustomerID".PadRight(20) + "CompanyName".PadRight(40) + "Country");

                Console.WriteLine(new string('-', 80));

                // Read through the data returned by the SqlDataReader
                while (reader.Read())
                {
                    string customerId = reader["CustomerID"]?.ToString() ?? string.Empty;

                    string companyName = reader["CompanyName"]?.ToString() ?? string.Empty;

                    string country = reader["Country"]?.ToString() ?? string.Empty;

                    Console.WriteLine(customerId.PadRight(20) + companyName.PadRight(40) + country);
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
