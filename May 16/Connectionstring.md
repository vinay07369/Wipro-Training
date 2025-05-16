string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

// Provide the query string with a parameter placeholder.
string queryString =
            "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                + "WHERE UnitPrice > @pricePoint "
                + "ORDER BY UnitPrice DESC;";