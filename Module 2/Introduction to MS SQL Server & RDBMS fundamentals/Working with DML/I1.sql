CREATE TABLE dbo.demoProduc (
    ProductID INT NOT NULL PRIMARY KEY,
    Name dbo.Name NOT NULL,
    Color NVARCHAR(15) NULL,
    StandardCost MONEY NOT NULL,
    ListPrice MONEY NOT NULL,
    Size NVARCHAR(5) NULL,
    Weight DECIMAL(8, 2) NULL
);
