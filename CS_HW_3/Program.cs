using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four digits:");
        string input = Console.ReadLine();

        if (input.Length == 4 && int.TryParse(input, out int number))
        {
            Console.WriteLine($"Result: {number}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter exactly four digits.");
        }
    }
}