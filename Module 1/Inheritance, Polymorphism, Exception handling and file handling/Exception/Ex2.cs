using System;

// Step 1: Define the custom exception
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        int[] marks = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < 0)
                    throw new NegativeNumberException("Marks cannot be negative.");

                marks[i] = input;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
                i--; // retry
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
                i--; // retry
            }
        }

        Console.WriteLine($"\nStudent Name: {name}");
        Console.WriteLine("Marks:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {marks[i]}");
        }
    }
}
