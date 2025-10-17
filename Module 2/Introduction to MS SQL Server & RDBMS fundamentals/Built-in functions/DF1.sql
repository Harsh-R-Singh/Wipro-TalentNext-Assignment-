SELECT 
    SalesOrderID,
    OrderDate,
    ShipDate,
    DATEDIFF(DAY, OrderDate, ShipDate) AS DaysToShip
FROM 
    Sales.SalesOrderHeader;
