SELECT 
    c.CustomerID,
    c.StoreID,
    c.TerritoryID,
    p.FirstName,
    p.LastName,
    soh.SalesOrderID
FROM 
    Sales.Customer AS c
JOIN 
    Person.Person AS p ON c.PersonID = p.BusinessEntityID
JOIN 
    Sales.SalesOrderHeader AS soh ON c.CustomerID = soh.CustomerID;
