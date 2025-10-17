using System;

public class Stock
{
    // Properties
    public string StockName { get; set; }
    public string StockSymbol { get; set; }
    public double PreviousClosingPrice { get; set; }
    public double CurrentClosingPrice { get; set; }

    // Constructor
    public Stock(string name, string symbol, double previousPrice, double currentPrice)
    {
        StockName = name;
        StockSymbol = symbol;
        PreviousClosingPrice = previousPrice;
        CurrentClosingPrice = currentPrice;
    }

    // Method to calculate percentage change
    public double GetChangePercentage()
    {
        if (PreviousClosingPrice == 0)
            return 0; // Avoid division by zero

        return ((CurrentClosingPrice - PreviousClosingPrice) / PreviousClosingPrice) * 100;
    }
}
class Program
{
    static void Main()
    {
        Stock s = new Stock("TechCorp", "TC", 150.00, 165.00);
        Console.WriteLine("Stock: " + s.StockName + " (" + s.StockSymbol + ")");
        Console.WriteLine("Change Percentage: " + s.GetChangePercentage() + "%");
    }
}
