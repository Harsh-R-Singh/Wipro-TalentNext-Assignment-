SELECT 
    e.JobTitle,
    e.BirthDate,
    p.FirstName,
    p.LastName
FROM 
    HumanResources.Employee AS e
JOIN 
    Person.Person AS p
ON 
    e.BusinessEntityID = p.BusinessEntityID;
