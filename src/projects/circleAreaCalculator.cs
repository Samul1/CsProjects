using System;

// 1. Program ask user circle radius
// 2. Then calculates its area
// 3. Print out the answer

namespace CircleAreaCalc
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Ask the radius
            Console.Write("Enter the radius of the Circle: ");
            // Save userinput
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of the Circle is: " + Math.PI * (radius * radius));

        }
    }
}