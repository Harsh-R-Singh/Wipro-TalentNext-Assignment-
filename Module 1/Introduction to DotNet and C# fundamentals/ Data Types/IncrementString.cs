using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = "";

        foreach (char c in input)
        {
            char incremented = (char)(c + 1);

            if (char.IsLower(incremented))
                result += char.ToUpper(incremented);
            else if (char.IsUpper(incremented))
                result += char.ToLower(incremented);
            else
                result += incremented; // For digits or symbols
        }

        Console.WriteLine("Transformed string: " + result);
    }
}
