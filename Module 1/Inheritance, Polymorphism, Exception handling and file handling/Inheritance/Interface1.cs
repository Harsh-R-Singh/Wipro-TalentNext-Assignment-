public interface IPayable
{
    double CalculatePay();
}
public class HourlyEmployee : Person, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string firstName, string lastName, string email, DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }
}
public class HourlyEmployee : Person, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string firstName, string lastName, string email, DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }
}
class Program
{
    static void Main()
    {
        IPayable emp1 = new HourlyEmployee("Ravi", "Kumar", "ravi@example.com", new DateTime(1995, 4, 10), 40, 500);
        IPayable emp2 = new PermanentEmployee("Sneha", "Verma", "sneha@example.com", new DateTime(1990, 5, 25), 60000);

        Console.WriteLine($"Hourly Employee Pay: ₹{emp1.CalculatePay()}");
        Console.WriteLine($"Permanent Employee Pay: ₹{emp2.CalculatePay()}");
    }
}
