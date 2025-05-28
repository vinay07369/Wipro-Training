// 1.SQL query to select ProductName and Total from the CustOrderHist stored procedure.
// Note: The stored procedure CustOrderHist should already exist in the Northwind database and should accept a parameter for CustomerID.
// The stored procedure should return ProductName and Total for the specified CustomerID.
// The stored procedure can be created in SQL Server Management Studio (SSMS) as follows:

// CREATE PROCEDURE CustOrderHist
// @CustomerID NCHAR(5)
// AS
// BEGIN
//     SELECT ProductName, SUM(UnitPrice * Quantity) AS Total
//     FROM [Order Details] od
//     INNER JOIN Products p ON od.ProductID = p.ProductID
//     INNER JOIN Orders o ON od.OrderID = o.OrderID
//     WHERE o.CustomerID = @CustomerID
//     GROUP BY ProductName
// END

using System;
using System.Data.SqlClient;

class StoredProcedure
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // Create a connection to the database and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create a SqlCommand to execute the stored procedure
            SqlCommand command = new SqlCommand("CustOrderHist", connection);

            // Specify that the command is a stored procedure
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Ask the user for the Customer ID
            Console.Write("Enter the Customer ID to retrieve order history: ");
            string customerId = Console.ReadLine();

            // Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@CustomerID", customerId); // Assuming CustomerID exists

            try
            {
                // Open the connection and execute the command
                connection.Open();

                // Execute the command and retrieve the data using SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Read through the data returned by the SqlDataReader
                while (reader.Read())
                {
                    string ProductName = reader["ProductName"]?.ToString() ?? string.Empty;

                    string Total = reader["Total"]?.ToString() ?? string.Empty;

                    // Display the results in a formatted manner
                    Console.WriteLine($"Product Name: {ProductName}, Total: {Total}");

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