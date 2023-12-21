using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        // C# Type Casting -----------------------------------------------

        // Type casting is when you assign a value of one data type to
        // another type.

        // In C#, there are two types of casting:

        // Implicit Casting(automatically) -converting a smaller type
        // to a larger type size:
        // char -> int -> long -> float -> double

        // Explicit Casting(manually) - converting a larger type to
        // a smaller size type:
        // double -> float -> long -> int -> char

        // Implicit Casting ----------------------------------------------

        // Implicit casting is done automatically when passing a smaller
        // size type to a larger size type:

        int myInt = 9;
        double myDouble = myInt;                // Automatic casting: int to double

        System.Console.WriteLine(myInt);        // Outputs 9
        System.Console.WriteLine(myDouble);     // Outputs 9

        // Explicit Casting ----------------------------------------------

        // Explicit casting must be done manually by placing the type in
        // parentheses in front of the value:

        double myDouble2 = 9.78;
        int myInt2 = (int)myDouble2;            // Manual casting: double to int

        System.Console.WriteLine(myDouble2);    // Outputs 9.78
        System.Console.WriteLine(myInt2);       // Outputs 9

        // Type Conversion Methods ---------------------------------------

        // It is also possible to convert data types explicitly by using
        // built-in methods, such as Convert.ToBoolean, Convert.ToDouble,
        // Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):

        int myInt3 = 10;
        double myDouble3 = 5.25;
        bool myBool = true;

        System.Console.WriteLine("This integer value is now string: " + Convert.ToString(myInt3));
        System.Console.WriteLine("This integer value is now double: " + Convert.ToDouble(myInt3));
        System.Console.WriteLine("This double value is now integer: " + Convert.ToInt32(myDouble3));
        System.Console.WriteLine("This boolean value is now string: " + Convert.ToString(myBool));

        // Why Conversion?

        // Many times, there's no need for type conversion. But sometimes
        // you have to. Take a look at the UserInput, to see an example of this.

    }
}