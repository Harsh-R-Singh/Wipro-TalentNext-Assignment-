using System;

public class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    public string FullName => $"{firstName} {lastName}";

    public bool IsAdult => (DateTime.Now.Year - dateOfBirth.Year - (DateTime.Now < dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) ? 1 : 0)) >= 18;

    public bool IsBirthDay => dateOfBirth.Day == DateTime.Now.Day && dateOfBirth.Month == DateTime.Now.Month;

    public string ScreenName => $"{firstName.Substring(0, 1).ToLower()}{lastName.ToLower()}{dateOfBirth:MMddyy}";
}
public class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string firstName, string lastName, string email, DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay() => HoursWorked * PayPerHour;
}
class Program
{
    static void Main()
    {
        // Hourly Employee
        HourlyEmployee hourlyEmp = new HourlyEmployee("Ravi", "Kumar", "ravi.kumar@example.com", new DateTime(1995, 4, 10), 40, 500);
        Console.WriteLine($"Hourly Employee: {hourlyEmp.FullName}");
        Console.WriteLine($"Screen Name: {hourlyEmp.ScreenName}");
        Console.WriteLine($"Is Adult: {hourlyEmp.IsAdult}");
        Console.WriteLine($"Is Birthday Today: {hourlyEmp.IsBirthDay}");
        Console.WriteLine($"Total Pay: ₹{hourlyEmp.CalculatePay()}");

        Console.WriteLine("\n-----------------------------\n");

        // Permanent Employee
        PermanentEmployee permEmp = new PermanentEmployee("Sneha", "Verma", "sneha.verma@example.com", new DateTime(1990, 5, 25), 60000);
        Console.WriteLine($"Permanent Employee: {permEmp.FullName}");
        Console.WriteLine($"Screen Name: {permEmp.ScreenName}");
        Console.WriteLine($"Is Adult: {permEmp.IsAdult}");
        Console.WriteLine($"Is Birthday Today: {permEmp.IsBirthDay}");
        Console.WriteLine($"Basic Salary: ₹{permEmp.BasicSalary}");
        Console.WriteLine($"HRA: ₹{permEmp.HRA}");
        Console.WriteLine($"DA: ₹{permEmp.DA}");
        Console.WriteLine($"Total Pay: ₹{permEmp.TotalPay}");
        Console.WriteLine($"Tax: ₹{permEmp.Tax}");
        Console.WriteLine($"Net Pay: ₹{permEmp.NetPay}");
    }
}
