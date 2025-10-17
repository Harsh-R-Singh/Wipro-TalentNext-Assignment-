SELECT 
    SalesOrderID,
    SUM(LineTotal) AS TotalLineAmount
FROM 
    Sales.SalesOrderDetail
GROUP BY 
    SalesOrderID
HAVING 
    SUM(LineTotal) > 1000;
