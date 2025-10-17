using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements separated by space: ");
        string[] input = Console.ReadLine().Split(' ');

        int count = 0;
        foreach (var item in input)
        {
            count++;
        }

        Console.WriteLine("Number of elements in the array: " + count);
    }
}
