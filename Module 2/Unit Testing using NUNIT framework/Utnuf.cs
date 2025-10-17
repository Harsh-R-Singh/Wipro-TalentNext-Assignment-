public class Calculator
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
using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string op = Console.ReadLine();

        try
        {
            double result = op switch
            {
                "+" => calc.Add(num1, num2),
                "-" => calc.Subtract(num1, num2),
                "*" => calc.Multiply(num1, num2),
                "/" => calc.Divide(num1, num2),
                _ => throw new InvalidOperationException("Invalid operator")
            };

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calc;

    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void TestAddition() => Assert.AreEqual(5, calc.Add(2, 3));

    [Test]
    public void TestSubtraction() => Assert.AreEqual(1, calc.Subtract(4, 3));

    [Test]
    public void TestMultiplication() => Assert.AreEqual(6, calc.Multiply(2, 3));

    [Test]
    public void TestDivision() => Assert.AreEqual(2, calc.Divide(6, 3));

    [Test]
    public void TestDivideByZero() =>
        Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
}
