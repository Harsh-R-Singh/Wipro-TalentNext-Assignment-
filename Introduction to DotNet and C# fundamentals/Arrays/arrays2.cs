using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        // Accept 10 integers
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // 1) Print elements in descending order
        Array.Sort(numbers); // Sort ascending
        Array.Reverse(numbers); // Reverse to descending
        Console.WriteLine("\nElements in descending order:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // 2) Find Min and Max values
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        Console.WriteLine($"\n\nMinimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");

        // 3) Calculate sum of all elements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of all elements: {sum}");
    }
}
