using System;
using System.Data.SqlClient;

class InsertProducts
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // SQL query to select CustomerID, CompanyName, and Country from the Customers table
        string sqlquery = @"INSERT INTO PRODUCTS (ProductName, SupplierID, CategoryID, UnitPrice) VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        // Create a connection to the database and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create a SqlCommand to execute the SQL query
            SqlCommand command = new SqlCommand(sqlquery, connection);

            // Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@ProductName", "Test Product");
            command.Parameters.AddWithValue("@SupplierID", 1);
            command.Parameters.AddWithValue("@CategoryID", 1);
            command.Parameters.AddWithValue("@UnitPrice", 25);

            try
            {
                // Open the connection and execute the command
                connection.Open();

                // Execute the command and retrieve the number of rows affected
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product inserted successfully.");
                }
                else
                {
                    Console.WriteLine("No rows were affected. Product may not have been inserted.");
                }
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
