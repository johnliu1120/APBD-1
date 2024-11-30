namespace ConsoleApp1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [10, 20, 30, 40, 50];

        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");

        int maximum = FindMaximum(numbers);
        Console.WriteLine($"The maximum value is: {maximum}");
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

    public static int FindMaximum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be null or empty.");
        }

        int maxInt = numbers[0]; 
        foreach (int number in numbers)
        {
            if (number > maxInt)
            {
                maxInt = number;
            }
        }

        return maxInt;
    }
}

