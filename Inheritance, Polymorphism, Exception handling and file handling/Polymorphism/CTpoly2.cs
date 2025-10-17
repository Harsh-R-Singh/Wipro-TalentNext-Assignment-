using System;

class Math
{
    // Add methods
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Multiply methods
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    // Subtract methods
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    // Divide methods
    public int Divide(int a, int b)
    {
        return b != 0 ? a / b : 0;
    }

    public int Divide(int a, int b, int c)
    {
        return (b != 0 && c != 0) ? a / b / c : 0;
    }
}

class Program
{
    static void Main()
    {
        Math math = new Math();

        Console.WriteLine(math.Add(2, 3));           // 5
        Console.WriteLine(math.Add(2, 3, 4));        // 9
        Console.WriteLine(math.Multiply(2, 3));      // 6
        Console.WriteLine(math.Multiply(2, 3, 4));   // 24
        Console.WriteLine(math.Subtract(10, 5));     // 5
        Console.WriteLine(math.Subtract(20, 5, 3));  // 12
        Console.WriteLine(math.Divide(10, 2));       // 5
        Console.WriteLine(math.Divide(100, 2, 5));   // 10
    }
}
