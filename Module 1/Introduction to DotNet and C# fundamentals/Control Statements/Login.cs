using System;

class Program
{
    static void Main()
    {
        string correctLogin = "admin";
        string correctPassword = "pass123";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (login == correctLogin && password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect login or password. Attempts left: " + (3 - attempts));
            }
        }

        Console.WriteLine("Access denied. Too many failed attempts.");
    }
}
