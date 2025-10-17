using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the main number (num1): ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the digit to check (num2): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        if (num1 % 10 == num2)
        {
            Console.WriteLine("Digit is in the unit's place.");
            found = true;
        }
        if ((num1 / 10) % 10 == num2)
        {
            Console.WriteLine("Digit is in the ten's place.");
            found = true;
        }
        if ((num1 / 100) % 10 == num2)
        {
            Console.WriteLine("Digit is in the hundred's place.");
            found = true;
        }
        if ((num1 / 1000) % 10 == num2)
        {
            Console.WriteLine("Digit is in the thousand's place.");
            found = true;
        }

        if (!found)
        {
            Console.WriteLine("Digit not found in the first four places.");
        }
    }
}
