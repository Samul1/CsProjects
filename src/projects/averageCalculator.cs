using System;

// 1. Program ask user for how many numbers for input.
// 2. Then program ask that many numbers and saves them in a List
// 3. Then prints out their average.

namespace averageCalc
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Lets create a list for userinput
            List<double> list = new List<double>();

            Console.WriteLine("How many numbers are you going to input?");
            int howManyInputs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyInputs; i++)
            {
                // Ask the first number
                Console.Write("Enter a number: ");
                // Use typecasting to get user input
                list.Add(Convert.ToDouble(Console.ReadLine()));
            }

            // Using Average(IEnumerable<Decimal>) to calculate an average
            double average = list.Average();
            Console.WriteLine($"The average is: {average}");

        }
    }
}