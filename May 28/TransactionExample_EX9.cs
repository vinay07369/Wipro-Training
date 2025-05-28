using System;
using System.Data.SqlClient;

namespace ConsoleAppM28
{
    using System;
    using System.Data.SqlClient;

    namespace ConsoleApp
    {
        internal class TransactionExample
        {
            static void Main()
            {
                string CS = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=true";

                using (SqlConnection conn = new SqlConnection(CS))
                {
                    conn.Open();


                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string orderQuery = "INSERT INTO Orders (CustomerID, OrderDate) VALUES (@CustomerID, @OrderDate)";
                        SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                        orderCmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
                        orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        orderCmd.ExecuteNonQuery();


                        SqlCommand getIdCmd = new SqlCommand("SELECT MAX(OrderID) FROM Orders", conn, transaction);
                        int orderId = (int)getIdCmd.ExecuteScalar();


                        string detailsQuery = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)";
                        SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn, transaction);
                        detailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                        detailsCmd.Parameters.AddWithValue("@ProductID", 1);
                        detailsCmd.Parameters.AddWithValue("@UnitPrice", 10.0);
                        detailsCmd.Parameters.AddWithValue("@Quantity", 5);
                        detailsCmd.ExecuteNonQuery();


                        transaction.Commit();
                        Console.WriteLine("Transaction committed successfully.");
                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        Console.WriteLine("Transaction failed: " + ex.Message);
                    }
                }
            }
        }
    }
    }