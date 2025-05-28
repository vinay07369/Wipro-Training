using System;
using System.Data.SqlClient;

namespace ConsoleAppM28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter CustomerID to search for orders:");
            string customerId = Console.ReadLine();

            //Condition to check whether customer ID is present or not
            if (!string.IsNullOrEmpty(customerId))
            {
                SearchCustometID.GetOrdersByCustomer(customerId);
            }
            else
            {
                Console.WriteLine("CustomerID cannot be empty.");
            }
        }
    }
    internal class SearchCustometID
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" + "Integrated Security=true";

        static string sqlquery = "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @CustomerID";

        //Method to get the Order details by customer ID
        public static void GetOrdersByCustomer(string customerId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlquery, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("OrderID".PadRight(20) + "OrderDate".PadRight(30) + "ShipCountry");
                Console.WriteLine(new string('-', 80));

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string orderId = reader["OrderID"]?.ToString() ?? string.Empty;

                        string orderDate = reader["OrderDate"]?.ToString() ?? string.Empty;

                        string shipCountry = reader["ShipCountry"]?.ToString() ?? string.Empty;

                        Console.WriteLine(orderId.PadRight(20) + orderDate.PadRight(30) + shipCountry);
                    }
                }
                else
                {
                    Console.WriteLine("No orders found for CustomerID: " + customerId);
                }
                reader.Close();
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}