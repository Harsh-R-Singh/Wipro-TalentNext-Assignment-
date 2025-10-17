public class MathOperations
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

public delegate double Operation(double x, double y);
using System;

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        string op = Console.ReadLine();

        Operation operation = op switch
        {
            "+" => math.Add,
            "-" => math.Subtract,
            "*" => math.Multiply,
            "/" => math.Divide,
            _ => throw new InvalidOperationException("Invalid operator")
        };

        double result = operation(num1, num2);
        Console.WriteLine($"Result: {result}");
    }
}
