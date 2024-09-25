using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        // Get User Input -----------------------------------------

        // You have already learned that Console.WriteLine() is used
        // to output(print) values. Now we will use Console.ReadLine()
        // to get user input.

        // In the following example, the user can input his or hers
        // username, which is stored in the variable userName.
        // Then we print the value of userName:

        // Type your username and press enter:
        System.Console.WriteLine("Enter username:");

        // Create a string variable and get input from the keyboard 
        // and store it in the variable:
        string userName = System.Console.ReadLine();

        // Print the value of the variable (userName), which will display
        // the input value:
        System.Console.WriteLine("Username is: " + userName);

        // User Input and Numbers ----------------------------------

        // The Console.ReadLine() method returns a string. Therefore,
        // you cannot get information from another data type, such as
        // int. The following program will cause an error:

        /*
        System.Console.WriteLine("Enter your age: ");
        int age = System.Console.ReadLine();
        System.Console.WriteLine("Your age is: " + age);
        */

        // The error message will be something like this:
        // Cannot implicitly convert type 'string' to 'int'

        // Like the error message says, you cannot implicitly convert
        // type 'string' to 'int'.

        // Luckily, for you, you just learned from TypeCasting,
        // that you can convert any type explicitly, by using
        // one of the Convert.To methods:

        System.Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Your age is: " + age );

        // Note: If you enter wrong input (e.g. text in a numerical
        // input), you will get an exception/error message (like
        // System.FormatException: 'Input string was not in a
        // correct format.').

    }
}