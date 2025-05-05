DECLARE @Result BIT

EXEC CheckProductExists @ProductID = 7, @Exists = @Result OUTPUT;

IF @Result = 1
	PRINT 'Product Exists';
ELSE
	PRINT 'Product Not Exists';