SELECT 
    ProductID,
    SUM(OrderQty) AS TotalItemsOrdered
FROM 
    Sales.SalesOrderDetail
GROUP BY 
    ProductID;
