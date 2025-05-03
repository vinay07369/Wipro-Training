CREATE TABLE Orders (
	OrderID INT PRIMARY KEY,
	ProductID INT,
	Quantity INT,
	OrderDate DATE,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);