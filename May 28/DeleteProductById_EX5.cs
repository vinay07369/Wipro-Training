using System;
using System.Data.SqlClient;

class DeleteProductByID
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // SQL query to select CustomerID, CompanyName, and Country from the Customers table
        string sqlquery = "DELETE FROM Products WHERE ProductID = @ProductID";

        // Create a connection to the database and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            Console.Write("Enter the Product ID to Delete the Product : ");
            int productId = Convert.ToInt32(Console.ReadLine());

            // Create a SqlCommand to execute the SQL query
            SqlCommand command = new SqlCommand(sqlquery, connection);

            // Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@ProductID", productId); // Assuming ProductID  exists

            try
            {
                // Open the connection and execute the command
                connection.Open();

                // Execute the command and retrieve the number of rows affected
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Product Deleted successfully for the ID - {productId}.");
                }
                else
                {
                    Console.WriteLine($"No Product Available With the ID - {productId}.");
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
