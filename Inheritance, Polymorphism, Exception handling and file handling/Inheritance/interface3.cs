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

    public double CalculatePay() => HoursWorked * PayPerHour;
}
public class PermanentEmployee : Person, IPayable
{
    public double BasicSalary { get; set; }
    public double HRA { get; private set; }
    public double DA { get; private set; }
    public double Tax { get; private set; }
    public double NetPay { get; private set; }

    public PermanentEmployee(string firstName, string lastName, string email, DateTime dob, double basicSalary)
        : base(firstName, lastName, email, dob)
    {
        BasicSalary = basicSalary;
        CalculateSalary();
    }

    private void CalculateSalary()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        double gross = BasicSalary + HRA + DA;
        Tax = gross * 0.08;
        NetPay = gross - Tax;
    }

    public double CalculatePay() => NetPay;
}
class Program
{
    static void Main()
    {
        IPayable hourly = new HourlyEmployee("Ravi", "Kumar", "ravi@example.com", new DateTime(1995, 4, 10), 40, 500);
        IPayable permanent = new PermanentEmployee("Sneha", "Verma", "sneha@example.com", new DateTime(1990, 5, 25), 60000);

        Console.WriteLine($"Hourly Employee Pay: ₹{hourly.CalculatePay()}");
        Console.WriteLine($"Permanent Employee Pay: ₹{permanent.CalculatePay()}");
    }
}
