using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers separated by space:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        if (numbers.Length == 2 && double.TryParse(numbers[0], out double value) && double.TryParse(numbers[1], out double percentage))
        {
            double result = (percentage / 100) * value;
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two numbers separated by space.");
        }
    }
}