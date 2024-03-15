using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter line length, filler symbol, and direction (h for horizontal, v for vertical):");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            Console.WriteLine("Enter filler symbol:");
            char filler = Console.ReadLine()[0];

            Console.WriteLine("Enter direction (h for horizontal, v for vertical):");
            char direction = Console.ReadLine()[0];

            if (direction == 'h')
            {
                DrawHorizontalLine(length, filler);
            }
            else if (direction == 'v')
            {
                DrawVerticalLine(length, filler);
            }
            else
            {
                Console.WriteLine("Invalid direction. Please enter 'h' for horizontal or 'v' for vertical.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for line length.");
        }
    }

    static void DrawHorizontalLine(int length, char filler)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(filler);
        }
        Console.WriteLine();
    }

    static void DrawVerticalLine(int length, char filler)
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(filler);
        }
    }
}