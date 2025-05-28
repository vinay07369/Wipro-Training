using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleAppM28
{
    internal class ProductsStock
    {
        static void Main()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=NorthWind;Integrated Security=true";

            string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(ds, "Products");

            
            DataTable productTable = ds.Tables["Products"];

            Console.WriteLine("Products with UnitsInStock > 20:\n");

            foreach (DataRow row in productTable.Rows)
            {
                int stock = Convert.ToInt32(row["UnitsInStock"]);

                if (stock > 20)
                {
                    Console.WriteLine("ID: " + row["ProductID"] +
                                      ", Name: " + row["ProductName"] +
                                      ", Stock: " + stock);
                }
            }
        }
    }
}