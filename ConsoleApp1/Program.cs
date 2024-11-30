namespace ConsoleApp1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be null or empty.");
        }

        double sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}

