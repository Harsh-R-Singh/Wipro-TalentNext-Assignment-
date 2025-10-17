using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Pre-increment assignment
        num2 = ++num1;
        Console.WriteLine("After pre-increment: num1 = " + num1 + ", num2 = " + num2);

        // Reset values for clarity
        Console.Write("Re-enter num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Re-enter num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Post-increment assignment
        num2 = num1++;
        Console.WriteLine("After post-increment: num1 = " + num1 + ", num2 = " + num2);

        // Swap values
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2);
    }
}
