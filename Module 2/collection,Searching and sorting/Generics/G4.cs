public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }
}
using System.Collections.Generic;

public class EmployeeData
{
    public List<Employee> EmployeeInfo { get; set; } = new List<Employee>();
}
using System;
using System.IO;

public class EmployeeManager
{
    private const string FilePath = "EmployeeData.csv";
    private EmployeeData data = new EmployeeData();

    public void AddEmployeeFromInput()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee ID: ");
        emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        emp.EmployeeName = Console.ReadLine();

        Console.Write("Enter Designation: ");
        emp.Designation = Console.ReadLine();

        Console.Write("Enter Joining Date (yyyy-mm-dd): ");
        emp.JoiningDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Department Name: ");
        emp.DepartmentName = Console.ReadLine();

        data.EmployeeInfo.Add(emp);
        AppendEmployeeToCSV(emp);
    }

    private void AppendEmployeeToCSV(Employee emp)
    {
        bool fileExists = File.Exists(FilePath);
        using (StreamWriter writer = new StreamWriter(FilePath, append: true))
        {
            if (!fileExists)
            {
                writer.WriteLine("EmployeeID,EmployeeName,Designation,JoiningDate,DepartmentName");
            }

            writer.WriteLine($"{emp.EmployeeID},{emp.EmployeeName},{emp.Designation},{emp.JoiningDate:yyyy-MM-dd},{emp.DepartmentName}");
        }
    }
}
class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager();

        Console.WriteLine("Enter employee details:");
        manager.AddEmployeeFromInput();

        Console.WriteLine("Employee data saved to CSV file.");
    }
}
