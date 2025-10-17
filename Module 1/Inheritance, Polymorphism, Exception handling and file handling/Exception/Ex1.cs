using System;

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
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter an integer value for marks.");
                i--; // retry the same subject
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
