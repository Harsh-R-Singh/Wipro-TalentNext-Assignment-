using System;

class AreaCalculator
{
    // Circle: πr²
    public void CalculateArea(double radius)
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {area}");
    }

    // Triangle: ½ × base × height
    public void CalculateArea(double baseLength, double height)
    {
        double area = 0.5 * baseLength * height;
        Console.WriteLine($"Area of Triangle: {area}");
    }

    // Rectangle: length × breadth
    public void CalculateArea(int length, int breadth)
    {
        int area = length * breadth;
        Console.WriteLine($"Area of Rectangle: {area}");
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();
        calc.CalculateArea(5.0);              // Circle
        calc.CalculateArea(4.0, 3.0);         // Triangle
        calc.CalculateArea(6, 2);             // Rectangle
    }
}
