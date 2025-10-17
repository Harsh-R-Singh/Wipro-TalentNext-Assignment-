SELECT 
    ProductID,
    ISNULL(Color, 'No Color') AS Color,
    Name
FROM 
    Production.Product;
