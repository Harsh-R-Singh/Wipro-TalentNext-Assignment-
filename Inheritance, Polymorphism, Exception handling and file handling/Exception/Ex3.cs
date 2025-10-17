using System;

// Custom exception
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

// Person class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void SetDetails(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException("Name cannot be empty.");

        if (age < 0)
            throw new NegativeNumberException("Age cannot be negative.");

        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            person.SetDetails(name, age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format! Age must be a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number too large! Please enter a valid age.");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"\nPerson Details: Name = {person.Name}, Age = {person.Age}");
    }
}
