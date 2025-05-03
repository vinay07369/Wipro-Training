SELECT 
	Products.ProductName,
	SUM(Orders.Quantity) AS TotalUnitsSold
From Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Products.ProductName;