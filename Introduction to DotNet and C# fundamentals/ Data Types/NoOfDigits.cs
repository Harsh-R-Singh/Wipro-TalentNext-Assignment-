using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int digitCount = 0;
        int letterCount = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                digitCount++;
            else if (char.IsLetter(c))
                letterCount++;
        }

        Console.WriteLine("Number of digits: " + digitCount);
        Console.WriteLine("Number of alphabets: " + letterCount);
    }
}
