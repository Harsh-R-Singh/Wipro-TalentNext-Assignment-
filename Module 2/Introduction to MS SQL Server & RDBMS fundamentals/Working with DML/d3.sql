WITH CustomerTotal AS (
    SELECT 
        c.CustomerID,
        SUM(soh.TotalDue) AS TotalSpent
    FROM 
        dbo.demoCustomer AS c
    LEFT JOIN 
        dbo.demoSalesOrderHeader AS soh ON c.CustomerID = soh.CustomerID
    GROUP BY 
        c.CustomerID
)
DELETE FROM dbo.demoCustomer
WHERE CustomerID IN (
    SELECT CustomerID
    FROM CustomerTotal
    WHERE TotalSpent IS NULL OR TotalSpent < 1000
);
