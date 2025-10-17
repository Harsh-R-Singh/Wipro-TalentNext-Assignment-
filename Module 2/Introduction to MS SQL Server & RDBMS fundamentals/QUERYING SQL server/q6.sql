SELECT 
    c.CustomerID,
    c.StoreID,
    c.TerritoryID,
    p.FirstName,
    p.LastName
FROM 
    Sales.Customer AS c
JOIN 
    Person.Person AS p
ON 
    c.PersonID = p.BusinessEntityID;
