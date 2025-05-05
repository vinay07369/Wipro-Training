CREATE PROCEDURE GetProductRevenue
	@ProductID INT
AS
BEGIN
	SELECT 
		o.Quantity,
		p.Price,
		(o.Quantity*p.Price) AS TotalRevenue
	FROM Orders o
	INNER JOIN Products p ON o.ProductID = p.ProductID
	WHERE o.ProductID = @ProductID
END;