using System;
using System.Data.SqlClient;

class UpdateEmpTitle
{
    static void Main()
    {
        // Connection string to connect to the Northwind database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        // SQL query to select CustomerID, CompanyName, and Country from the Customers table
        string sqlquery = @"UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";

        // Create a connection to the database and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            Console.Write("Enter the Employee ID to Update the Title : ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the New Title for the Employee : ");
            string newTitle = Console.ReadLine();

            // Create a SqlCommand to execute the SQL query
            SqlCommand command = new SqlCommand(sqlquery, connection);

            // Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@Title", newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId); // Assuming EmployeeID 1 exists

            try
            {
                // Open the connection and execute the command
                connection.Open();

                // Execute the command and retrieve the number of rows affected
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Employee Title Updated successfully for the ID - {employeeId}.");
                }
                else
                {
                    Console.WriteLine($"No Employee With the ID - {employeeId}.");
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
