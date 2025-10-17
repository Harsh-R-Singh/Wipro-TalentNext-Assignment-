using System;

public class Person
{
    // Private fields
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    // Constructor
    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    // Read-only property: IsAdult
    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now < dateOfBirth.AddYears(age)) age--;
            return age >= 18;
        }
    }

    // Read-only property: SunSign
    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            return (month, day) switch
            {
                (1, <= 19) => "Capricorn",
                (1, _) => "Aquarius",
                (2, <= 18) => "Aquarius",
                (2, _) => "Pisces",
                (3, <= 20) => "Pisces",
                (3, _) => "Aries",
                (4, <= 19) => "Aries",
                (4, _) => "Taurus",
                (5, <= 20) => "Taurus",
                (5, _) => "Gemini",
                (6, <= 20) => "Gemini",
                (6, _) => "Cancer",
                (7, <= 22) => "Cancer",
                (7, _) => "Leo",
                (8, <= 22) => "Leo",
                (8, _) => "Virgo",
                (9, <= 22) => "Virgo",
                (9, _) => "Libra",
                (10, <= 22) => "Libra",
                (10, _) => "Scorpio",
                (11, <= 21) => "Scorpio",
                (11, _) => "Sagittarius",
                (12, <= 21) => "Sagittarius",
                _ => "Capricorn"
            };
        }
    }

    // Read-only property: IsBirthDay
    public bool IsBirthDay => dateOfBirth.Day == DateTime.Now.Day && dateOfBirth.Month == DateTime.Now.Month;

    // Read-only property: ScreenName
    public string ScreenName
    {
        get
        {
            string initials = firstName.Substring(0, 1).ToLower() + lastName.ToLower();
            string datePart = dateOfBirth.ToString("MMddyy");
            return $"{initials}{datePart}";
        }
    }
    public class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email, DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Hari", "Doe", "hari.doe@example.com", new DateTime(1980, 5, 25), 75000);

        Console.WriteLine("Is Adult: " + emp.IsAdult);
        Console.WriteLine("Sun Sign: " + emp.SunSign);
        Console.WriteLine("Is Birthday Today: " + emp.IsBirthDay);
        Console.WriteLine("Screen Name: " + emp.ScreenName);
        Console.WriteLine("Salary: " + emp.Salary);
    }
}

}
