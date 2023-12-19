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


        }
    }
}