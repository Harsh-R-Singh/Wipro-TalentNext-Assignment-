using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string with words, letters, and digits: ");
        string input = Console.ReadLine();

        List<char> AlphaList = new List<char>();
        List<char> DigitList = new List<char>();

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
                AlphaList.Add(ch);
            else if (char.IsDigit(ch))
                DigitList.Add(ch);
        }

        AlphaList.Sort();
        DigitList.Sort();

        Console.WriteLine("\nSorted Alphabets:");
        Console.WriteLine(string.Join(", ", AlphaList));

        Console.WriteLine("\nSorted Digits:");
        Console.WriteLine(string.Join(", ", DigitList));
    }
}
