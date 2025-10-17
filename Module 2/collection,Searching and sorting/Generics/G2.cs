public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}
using System;
using System.Collections.Generic;

public class EmployeeDAL
{
    private List<Employee> employeeList = new List<Employee>();

    public bool AddEmployee(Employee e)
    {
        employeeList.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        var emp = employeeList.Find(e => e.EmployeeID == id);
        if (emp != null)
        {
            employeeList.Remove(emp);
            return true;
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        var emp = employeeList.Find(e => e.EmployeeID == id);
        return emp?.EmployeeName;
    }

    public Employee[] GetAllEmployeesistAll()
    {
        return employeeList.ToArray();
    }
}
class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee("Harsh Raj", 101, 50000));
        dal.AddEmployee(new Employee("Anjali Sharma", 102, 60000));
        dal.AddEmployee(new Employee("Ravi Kumar", 103, 55000));

        Console.WriteLine(dal.SearchEmployee(102) ?? "Employee not found");

        dal.DeleteEmployee(101);

        Console.WriteLine("\nAll Employees:");
        foreach (Employee emp in dal.GetAllEmployeesistAll())
        {
            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Salary: {emp.Salary}");
        }
    }
}
