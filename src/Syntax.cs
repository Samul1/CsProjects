// Syntax tutorial from https://www.w3schools.com/cs/cs_syntax.php

// Line 5: "using System" means that we can use classes from
// the System namespace.
using System;

// Line 9: A blank line. C# ignores white space.
// However, multiple lines makes the code more readable.

// Line 12: "namespace" is used to organize your code, and it 
// is a container for classes and other namespaces.
namespace HelloWorld

// Line 16: The curly braces {} marks the beginning and end 
// of a block of code.
{
    // Line 21: "class" is container for data and methods, which
    // brings functionality to your program. Every line of code
    // that runs in C# must be insede a class. In our example,
    // we named the class Program.
    class Program
    {
        // Line 26: Another thing that always appear in a C# program,
        // is the Main method. Any code inside its curly brackets {}
        // will be executed.
        static void Main(string[] args)
        {
            // Line 32: Console is a class of the System namespace,
            // which has a WriteLine() method that is used to
            // output/print text. In our example it will output
            // "Hello World!".
            Console.WriteLine("Hello World!");

            // Line 37: If you omit the using System line, you would
            // have to write System.Console.WriteLine() to
            // print/output text.
            System.Console.WriteLine("Hello World!");
        }
    }
}