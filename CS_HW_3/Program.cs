using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }
        }

        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];
        int product = 1;

        foreach (int num in numbers)
        {
            sum += num;
            product *= num;
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Product: {product}");
    }
}