CREATE DATABASE EmployeeManagement;
GO

USE EmployeeManagement;
GO

CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmpName NVARCHAR(100) NOT NULL,
    Designation NVARCHAR(100),
    Qualification NVARCHAR(100),
    JoiningDate DATE
);
