using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // 1) Reverse the string
        char[] reversedArray = input.ToCharArray();
        Array.Reverse(reversedArray);
        string reversed = new string(reversedArray);
        Console.WriteLine("Reversed string: " + reversed);

        // 2) Extract from 2nd position
        string substring = input.Substring(1);
        Console.WriteLine("Substring from 2nd character: " + substring);

        // 3) Replace a character with '$'
        Console.Write("Enter character to replace: ");
        char toReplace = Console.ReadLine()[0];
        string replaced = input.Replace(toReplace, '$');
        Console.WriteLine("String after replacement: " + replaced);

        // 4) Copy and modify second string
        string copy = input;
        string modifiedCopy = copy.ToUpper(); // Example modification
        Console.WriteLine("Original string: " + copy);
        Console.WriteLine("Modified copy: " + modifiedCopy);
    }
}
