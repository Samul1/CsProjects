using System;

// 1. Program ask if the user want to convert Celcius -> Fahrenheit or other way around.
// 2. Then calculates its area
// 3. Print out the answer

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Variables
            bool end = false;
            bool isNumeric = false;
            string errorMsg = "Check input";

            // Main loop starts here
            while (end != true)
            {
                // Print out main menu
                Console.WriteLine("Temperature converter");
                Console.WriteLine("1. Celcius    -> Fahrenheit");
                Console.WriteLine("2. Fahrenheit -> Celcius");
                Console.WriteLine("0. Exit");
                // Takes userInput as string
                string userInput = Console.ReadLine();

                // Check if userInput can be converted to integer
                isNumeric = int.TryParse(userInput, out _);
                // If it can
                if (isNumeric == true) 
                {
                    // Convert userInput to integer
                    int input = Convert.ToInt32(userInput);
                    // Check input validity
                    if (input >= 0 && input < 3)
                    {
                        // Handle input
                        switch (input)
                        {
                            // Celcius -> Fahrenheit
                            case 1: Calculate(input); Console.Clear(); break;
                            // Fahrenheit -> Celcius
                            case 2: Calculate(input); Console.Clear(); break;
                            // Exit
                            case 0: end = true; break;
                            default: Console.Clear(); Console.WriteLine(errorMsg); break;
                        }
                    }
                    // If input is not between 0 to 2
                    else
                    {
                        Console.Clear();
                        // Wrong input
                        Console.WriteLine(errorMsg);
                    }
                }
                // If userInput cannot be converted to integer
                else
                {
                    Console.Clear();
                    Console.WriteLine(errorMsg);
                }
            }
        }

        // Method will convert celcius to fahrenheit or other way around
        static void Calculate(int userInput)
        {
            Console.WriteLine("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double result;

            // calculations and output
            // if Celcius -> Fahrenheit
            if(userInput == 1)
            {
                // Convert celcius to fahrenheit
                result = ((temp * 9) / 5) + 32;
                Console.WriteLine($"{temp} Celcius is: {(Math.Round(result, 2))} Fahrenheit.");
            }
            // if Fahrenheit -> Celcius
            else if(userInput == 2)
            {
                result = (temp - 32) * 5 / 9;
                Console.WriteLine($"{temp} Fahrenheit is: {(Math.Round(result, 2))} Celcius.");
            }
            // Wait for user to press any key...
            Console.ReadKey();
        }

    }
}