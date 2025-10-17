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
using System.Collections;

public class EmployeeDAL
{
    private ArrayList employeeList = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        employeeList.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
            {
                employeeList.Remove(emp);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
                return emp.EmployeeName;
        }
        return null;
    }

    public Employee[] GetAllEmployeesistAll()
    {
        return (Employee[])employeeList.ToArray(typeof(Employee));
    }
}
using System;

class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        // Add Employees
        dal.AddEmployee(new Employee("Harsh Raj", 101, 50000));
        dal.AddEmployee(new Employee("Anjali Sharma", 102, 60000));
        dal.AddEmployee(new Employee("Ravi Kumar", 103, 55000));

        // Search Employee
        string name = dal.SearchEmployee(102);
        Console.WriteLine(name != null ? $"Employee Found: {name}" : "Employee not found");

        // Delete Employee
        bool deleted = dal.DeleteEmployee(101);
        Console.WriteLine(deleted ? "Employee deleted successfully" : "Employee not found");

        // List All Employees
        Console.WriteLine("\nAll Employees:");
        foreach (Employee emp in dal.GetAllEmployeesistAll())
        {
            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Salary: {emp.Salary}");
        }
    }
}
