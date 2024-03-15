using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        if (int.TryParse(Console.ReadLine(), out int number1) && int.TryParse(Console.ReadLine(), out int number2))
        {
            
            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

            Console.WriteLine($"Even numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two integers.");
        }
    }
}