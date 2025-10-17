SELECT 
    SalesOrderID,
    ROUND(SubTotal, 2) AS RoundedSubTotal
FROM 
    Sales.SalesOrderHeader;
