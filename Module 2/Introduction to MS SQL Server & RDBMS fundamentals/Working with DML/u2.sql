UPDATE sod
SET sod.UnitPrice = p.ListPrice
FROM dbo.demoSalesOrderDetail AS sod
JOIN dbo.demoProduct AS p
ON sod.ProductID = p.ProductID;
