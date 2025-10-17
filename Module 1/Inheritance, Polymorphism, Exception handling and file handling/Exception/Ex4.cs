using System;
using System.Text.RegularExpressions;

public class InvalidNameException : Exception
{
    public InvalidNameException(string message) : base(message) { }
}

public class Person
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get => firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("First name cannot be empty.");

            if (!Regex.IsMatch(value, @"^[A-Za-z]+$"))
                throw new InvalidNameException("First name must contain only alphabets.");

            firstName = value;
        }
    }

    public string LastName
    {
        get => lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Last name cannot be empty.");

            if (!Regex.IsMatch(value, @"^[A-Za-z]+$"))
                throw new InvalidNameException("Last name must contain only alphabets.");

            lastName = value;
        }
    }
}
class Program
{
    static void Main()
    {
        Person person = new Person();

        try
        {
            Console.Write("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine($"\nFull Name: {person.FirstName} {person.LastName}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}