using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //To output values or print text in C#,
            //you can use the WriteLine() method:
            System.Console.WriteLine("Hello World!");

            // You can add as many WriteLine() methods as you want.
            // Note that it will add a new line for each method:
            System.Console.WriteLine("I am learning C#");
            System.Console.WriteLine("It is awesome!");

            // You can also output numbers and perform
            // mathematical calculation:
            System.Console.WriteLine(3 + 3);

            // The Write Method ----------------------------------

            // There is also a Write() method, which is similar
            // to WriteLine().

            //The only difference is that it does not insert
            //a new line at the end of the output:
            System.Console.Write("Hello World! ");
            System.Console.Write("I will print on the same line.");
            
            // Note that we add an extra space when needed
            // (after "Hello World!" in the example above),
            // for better readability.
        }
    }
}