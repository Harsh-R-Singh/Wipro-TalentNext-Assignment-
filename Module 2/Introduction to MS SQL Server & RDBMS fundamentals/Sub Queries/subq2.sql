SELECT ProductID, Name
FROM Production.Product
WHERE ProductID IN (
    SELECT DISTINCT ProductID
    FROM Sales.SalesOrderDetail
);
