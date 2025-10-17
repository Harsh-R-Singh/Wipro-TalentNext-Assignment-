SELECT 
    ProductLine,
    COUNT(*) AS ProductCount
FROM 
    Production.Product
GROUP BY 
    ProductLine;
