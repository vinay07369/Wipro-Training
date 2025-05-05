CREATE PROCEDURE CheckProductExists
	@ProductID INT,
	@Exists BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Products WHERE ProductID = @ProductID )
		SET @Exists = 1; -- True
	ELSE
		SET @Exists = 0; -- False
END;