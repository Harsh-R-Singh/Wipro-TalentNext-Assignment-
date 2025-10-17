SELECT 
    SalesOrderID,
    OrderDate,
    YEAR(OrderDate) AS OrderYear,
    MONTH(OrderDate) AS OrderMonth
FROM 
    Sales.SalesOrderHeader;
