using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "StudentNotes.txt";

        try
        {
            // Create and write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Student Name: Harsh Raj Singh");
                writer.WriteLine("Stream: DotNet-Full Stack");
                writer.WriteLine("Module: File Handling");
                writer.WriteLine("Status: Completed");
            }

            Console.WriteLine("File created and contents written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
