using System;

public class Employee
{
    // Properties
    public string EmployeeName { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal HRA { get; private set; }
    public decimal DA { get; private set; }
    public decimal GrossPay { get; private set; }
    public decimal Tax { get; private set; }
    public decimal NetPay { get; private set; }

    // Constructor
    public Employee(string name, decimal basicSalary)
    {
        EmployeeName = name;
        BasicSalary = basicSalary;
    }

    // Method to calculate salary components
    public void CalculateNetPay()
    {
        HRA = BasicSalary * 0.15m;
        DA = BasicSalary * 0.10m;
        GrossPay = BasicSalary + HRA + DA;
        Tax = GrossPay * 0.08m;
        NetPay = GrossPay - Tax;
    }

    // Method to display salary structure
    public void Display()
    {
        Console.WriteLine("Employee Name: " + EmployeeName);
        Console.WriteLine("Basic Salary: " + BasicSalary);
        Console.WriteLine("HRA (15%): " + HRA);
        Console.WriteLine("DA (10%): " + DA);
        Console.WriteLine("Gross Pay: " + GrossPay);
        Console.WriteLine("Tax (8%): " + Tax);
        Console.WriteLine("Net Pay: " + NetPay);
    }
}
