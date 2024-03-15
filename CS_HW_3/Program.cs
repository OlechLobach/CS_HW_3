using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a six-digit number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine($"Reversed number: {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a six-digit number.");
        }
    }

    static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = (reversed * 10) + digit;
            num /= 10;
        }
        return reversed;
    }
}