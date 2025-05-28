using System;
using System.Data;
using System.Data.SqlClient;

class TotalSalByCategory
{
   static void Main()
   {
       // Connection string to connect to the Northwind database
       string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

       // SQL query to select OrderID, TotalSales from Order Details Table and Group them By OrderID
       string sqlquery = "SELECT OrderID, SUM(UnitPrice * Quantity) AS TotalSales FROM [Order Details] GROUP BY OrderID ";

       // Create a connection to the database and execute the query
       using (SqlConnection connection = new SqlConnection(connectionString))
       {
           // Create a SqlDataAdapter to execute the SQL query
           SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, connection);

           // Create a DataTable to hold the results
           DataTable dataTable = new DataTable();

           try
           {
               // Open the connection and fill the DataTable with the results
               connection.Open();

               adapter.Fill(dataTable);

               Console.WriteLine("OrderID".PadRight(15) + "TotalSales");
               Console.WriteLine(new string('-', 30));

               // Read through the data in the DataTable and display it
               foreach (DataRow row in dataTable.Rows)
               {
                   string categoryId = row["OrderID"]?.ToString() ?? string.Empty;

                   string totalSales = row["TotalSales"]?.ToString() ?? string.Empty;

                   Console.WriteLine(categoryId.PadRight(15) + totalSales);
               }

               adapter.Dispose();
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
