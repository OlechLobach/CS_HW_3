using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the range (two integers separated by space):");
        if (int.TryParse(Console.ReadLine(), out int start) && int.TryParse(Console.ReadLine(), out int end))
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine($"Fibonacci numbers in the range {start} to {end}:");
            int a = 0, b = 1, c = 0;

            while (c <= end)
            {
                if (c >= start)
                {
                    Console.WriteLine(c);
                }
                c = a + b;
                a = b;
                b = c;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two integers.");
        }
    }
}