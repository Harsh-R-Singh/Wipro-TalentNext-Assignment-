using System;

public static class RandomHelper
{
    private static Random random = new Random();

    // 1. Static method to return a random integer (inclusive)
    public static int RandInt(int min, int max)
    {
        return random.Next(min, max + 1); // max is inclusive
    }

    // 2. Static method to return a random double (1 <= x < 10)
    public static double RandDouble(int min, int max)
    {
        return random.NextDouble() * (max - min) + min; // max is exclusive
    }
}
class Program
{
    static void Main()
    {
        // Call static methods without instantiating RandomHelper
        int randomInt = RandomHelper.RandInt(1, 10);
        double randomDouble = RandomHelper.RandDouble(1, 10);

        Console.WriteLine("Random Integer (1 to 10): " + randomInt);
        Console.WriteLine("Random Double (1 <= x < 10): " + randomDouble);
    }
}
