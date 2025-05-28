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

