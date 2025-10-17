public class ServiceToken
{
    private static int tokenCounter = 1000;

    public int TokenID { get; private set; }
    public int Position { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }

    public ServiceToken(int position)
    {
        TokenID = ++tokenCounter;
        Position = position;
        TicketDateTime = DateTime.Now;
        Status = "Pending";
    }

    public override string ToString()
    {
        return $"TokenID: {TokenID}, Position: {Position}, DateTime: {TicketDateTime}, Status: {Status}";
    }
}
using System;
using System.Collections.Generic;

public class TicketManager
{
    public Queue<ServiceToken> TokenQueue { get; set; } = new Queue<ServiceToken>();
    private List<ServiceToken> allTokens = new List<ServiceToken>();
    private int positionCounter = 1;

    public void GenerateServiceToken()
    {
        ServiceToken token = new ServiceToken(positionCounter++);
        TokenQueue.Enqueue(token);
        allTokens.Add(token);
        Console.WriteLine($"Token Created: {token.TokenID}");
    }

    public ServiceToken GetNextToken()
    {
        if (TokenQueue.Count > 0)
        {
            var token = TokenQueue.Peek();
            Console.WriteLine($"Next Token: {token}");
            return token;
        }
        Console.WriteLine("No tokens available.");
        return null;
    }

    public void UpdateToken(int tokenID)
    {
        var token = allTokens.Find(t => t.TokenID == tokenID);
        if (token != null)
        {
            token.Status = "Completed";
            Console.WriteLine($"Token {tokenID} marked as Completed.");
        }
        else
        {
            Console.WriteLine("Token not found.");
        }
    }

    public ServiceToken SkipToken()
    {
        if (TokenQueue.Count > 1)
        {
            TokenQueue.Dequeue(); // Skip first
            var next = TokenQueue.Peek();
            Console.WriteLine($"Skipped. Next Token: {next}");
            return next;
        }
        Console.WriteLine("Not enough tokens to skip.");
        return null;
    }

    public void ListAllTokens()
    {
        if (allTokens.Count == 0)
        {
            Console.WriteLine("No tokens generated yet.");
            return;
        }

        foreach (var token in allTokens)
        {
            Console.WriteLine(token);
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        TicketManager manager = new TicketManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n******************************** TOKEN MANAGEMENT SYSTEM ********************************");
            Console.WriteLine("1. Create Token");
            Console.WriteLine("2. Get Next Token");
            Console.WriteLine("3. Update Token");
            Console.WriteLine("4. Skip Token");
            Console.WriteLine("5. List all tokens");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your Choice? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.GenerateServiceToken();
                    break;
                case "2":
                    manager.GetNextToken();
                    break;
                case "3":
                    Console.Write("Enter Token ID to update: ");
                    if (int.TryParse(Console.ReadLine(), out int updateID))
                        manager.UpdateToken(updateID);
                    else
                        Console.WriteLine("Invalid Token ID.");
                    break;
                case "4":
                    manager.SkipToken();
                    break;
                case "5":
                    manager.ListAllTokens();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting application...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
