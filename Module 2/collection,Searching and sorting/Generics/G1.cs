using System;
using System.Collections.Generic;

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

public class EmployeeDAL
{
    private SortedList<int, Employee> employeeList = new SortedList<int, Employee>();

    public bool AddEmployee(Employee e)
    {
        if (!employeeList.ContainsKey(e.EmployeeID))
        {
            employeeList.Add(e.EmployeeID, e);
            return true;
        }
        return false;
    }

    public bool DeleteEmployee(int id)
    {
        return employeeList.Remove(id);
    }

    public string SearchEmployee(int id)
    {
        return employeeList.ContainsKey(id) ? employeeList[id].EmployeeName : null;
    }

    public Employee[] GetAllEmployeesistAll()
    {
        return new List<Employee>(employeeList.Values).ToArray();
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
