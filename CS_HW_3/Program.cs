using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a six-digit number:");
        string inputNumber = Console.ReadLine();

        if (inputNumber.Length != 6 || !int.TryParse(inputNumber, out int number))
        {
            Console.WriteLine("Error: Please enter a six-digit number.");
            return;
        }

        Console.WriteLine("Enter the positions of the digits to swap separated by space (e.g., '1 6'):");
        string inputPositions = Console.ReadLine();
        string[] positions = inputPositions.Split(' ');

        if (positions.Length != 2 || !int.TryParse(positions[0], out int position1) || !int.TryParse(positions[1], out int position2))
        {
            Console.WriteLine("Error: Please enter two positions separated by space.");
            return;
        }

        if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
        {
            Console.WriteLine("Error: Positions should be between 1 and 6.");
            return;
        }

        char[] numberArray = inputNumber.ToCharArray();
        char temp = numberArray[position1 - 1];
        numberArray[position1 - 1] = numberArray[position2 - 1];
        numberArray[position2 - 1] = temp;

        string result = new string(numberArray);
        Console.WriteLine($"Result: {result}");
    }
}