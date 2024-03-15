using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integers A and B (A < B):");
        if (int.TryParse(Console.ReadLine(), out int A) && int.TryParse(Console.ReadLine(), out int B) && A < B)
        {
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two positive integers where A < B.");
        }
    }
}