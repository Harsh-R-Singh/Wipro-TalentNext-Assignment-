SELECT 
    p.ProductID,
    p.Name,
    sod.SalesOrderID
FROM 
    Production.Product AS p
LEFT JOIN 
    Sales.SalesOrderDetail AS sod
ON 
    p.ProductID = sod.ProductID;
