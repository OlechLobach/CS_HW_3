using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");

        if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
        {
            double temperature;

            if (choice == 1)
            {
                Console.WriteLine("Enter the temperature in Fahrenheit:");
                if (double.TryParse(Console.ReadLine(), out temperature))
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    Console.WriteLine($"Temperature in Celsius: {celsius}");
                }
                else
                {
                    Console.WriteLine("Invalid temperature value.");
                }
            }
            else
            {
                Console.WriteLine("Enter the temperature in Celsius:");
                if (double.TryParse(Console.ReadLine(), out temperature))
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                }
                else
                {
                    Console.WriteLine("Invalid temperature value.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid option. Please choose either 1 or 2.");
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}