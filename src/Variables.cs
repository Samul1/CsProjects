using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables are containers for storing data values.

            // To create a variable, you must specify the type
            // and assign it a value:

            // type variableName = value;

            // Where type is a C# type (such as int or string),
            // and variableName is the name of the variable
            // (such as x or name). The equal sign is used to
            // assign values to the variable.

            // In C#, there are different types of variables
            // (defined with different keywords), for example:

            // int - Stores integer (whole numbers), without decimals,
            // such as 123 or -123.
            int a = 0;
            System.Console.WriteLine(a);

            // double - Stores floating point number, wtih decimals,
            // such as 19.99 or -19.99.
            double b = 0.00D;
            System.Console.WriteLine(b);

            // char - stores single characters, such as 'a' or 'B'.
            // Char values are surrounded by single quotes.
            char c = 'a';
            System.Console.WriteLine(c);    

            // string - stores text, such as "Hello World". String 
            // values are surrounded by double quotes.
            string d = "Hello World";
            System.Console.WriteLine(d);

            // bool - stores values with two states: true or false.
            bool e = false;
            System.Console.WriteLine(e);

            // You can also declare a variable without assigning
            // the value, and assign the value later:
            int f;
            f = 15;
            System.Console.WriteLine(f);

            // Note that if you assign a new value to an
            // existing variable, it will overwrite the previous value:
            int g = 15;
            g = 20; // Now g is 20
            System.Console.WriteLine(g);

            // Constant Variables --------------------------------

            // If you don't want others (or yourself) to overwrite
            // existing values, you can add the const keyword in
            // front of the variable type.
            // This will declare the variable as "constant",
            // which means unchangeable and read - only:
            const int h = 15;
            // h = 20; // error

            // The const keyword is useful when you want a variable
            // to always store the same value, so that others
            // (or yourself) won't mess up your code. An example that
            // is often referred to as a constant, is PI (3.14159...).

            // Note: You cannot declare a constant variable without
            // assigning the value. If you do, an error will occur:
            // A const field requires a value to be provided.

            // Display Variables ----------------------------------

            // The WriteLine() method is often used to display variable
            // values to the console window. To combine both text and
            // a variable, use the +character:

            string name = "John";
            System.Console.WriteLine("Hello " + name);

            // You can also use the + character to add variable
            // to another variable:

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            System.Console.WriteLine(fullName);

            // for numeric values, the + Characteristics works
            // as a mathematical operator (notice that we ues int 
            // (integer) variable here):

            int x = 5;
            int y = 6;
            System.Console.WriteLine(x + y); // Print the value of x + y

            // From the exmple above, you can expect:
            // - x stores the value 5.
            // - y stores the value 6.
            // Then we use the WriteLine() method to display the value
            // of x + y, which is 11.

            // Multiple Variables --------------------------------------

            // Declare Many Variables
            // To declare more than one variable of the same type, use
            // a comma-separated list:

            int num1 = 5, num2 = 6, num3 = 50;
            System.Console.WriteLine(num1 + num2 + num3);

            // You can also assign the same value to multiple
            // variables in one line:

            int num4, num5, num6;
            num4 = num5 = num6 = 50;
            System.Console.WriteLine(num4 + num5 + num6);

            // C# Identifiers -----------------------------------------

            // All C# variables must be identified with unique names.

            // These unique names are called identifiers.

            // Identifiers can be short names (like x and y) or more
            // descriptive names (ages, sum, totalVolume).

            // Note: It is recommended to use descriptive names in order
            // to create understandable and maintainable code:

            // Good:
            const int minutesPerHour = 60;
            System.Console.WriteLine("One hour has " + minutesPerHour + " minutes.");

            // OK, but not so easy to understand waht m actually is:
            const int s = 60;
            System.Console.WriteLine("One minute has " + s + " seconds.");

            // The general rules for naming variables are:

            // - Names can contain letters, digits and the underscore character (_).
            // - Names must begin with a letter or underscore.
            // - Names should start with a lowercase letter and it cannot contain whitespace.
            // - Names are case sensitive ("myVar" and "myvar" are different variables).
            // - Reserved words (like C# keywords, such as "int" or "double") cannot be
            // used as names.

        }
    }
}