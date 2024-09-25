using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        // Operators --------------------------------------------------

        // Operators are used to perform operations on variables and
        // values.

        // In the example below, we use the + operator to add together
        // two values:

        int x = 100 + 50;

        // Although the + operator is often used to add together two
        // values, like in the example above, it can also be used to
        // add together a variable and a value, or a variable and
        // another variable:

        int sum1 = 100 + 50;            // 150 (100 + 50)
        int sum2 = sum1 + 250;          // 400 (150 + 250)
        int sum3 = sum2 + sum2;         // 800 (400 + 400)

        // Arithmetic Operators ---------------------------------------

        // Arithmetic operators are used to perform common mathematical
        // operations:

        /*
        ---------------------------------------------------------------------------
         Operator | Name            | Description                       | Example |
        ---------------------------------------------------------------------------
        +         | Addition        | Adds together two values.         | x + y   |
        ---------------------------------------------------------------------------
        -         | Subtraction     | Subtracts one value from          | x - y   |
                  |                 | another.                          |         |
        ---------------------------------------------------------------------------
        *         | Multiplication  | Multiplies two values.            | x * y   |
        ---------------------------------------------------------------------------
        /         | Division        | Divides one value by another.     | x / y   |
        ---------------------------------------------------------------------------
        %         | Modulus         | Returns the division remainder.   | x % y   |
        ---------------------------------------------------------------------------
        ++        | Increment       | Increases the value of            | x++     |
                  |                 | a variable by 1.                  |         |
        ---------------------------------------------------------------------------
        --        | Decrement       | Decreases the value of            | x--     |
                  |                 | a variable by 1.                  |         |
        ---------------------------------------------------------------------------
         */

        // Assignment Operators ----------------------------------------------------

        // Assignment operators are used to assign values to variables.

        // In the example below, we use the assignment operator (=) to
        // assign the value 10 to a variable called y:

        int y = 10;

        // The addition assignment operator (+=) adds a value to a variable:

        int z = 10;
        z += 5;
        System.Console.WriteLine("Value of z is now: " + z);

        // A list of all assigment operators:

        /*
        -------------------------------------
        Operator    | Example   | Same As   |
        -------------------------------------
        =           | x = 5     | x = 5     |
        -------------------------------------
        +=          | x += 5    | x = x + 5 |
        -------------------------------------
        -=          | x -= 5    | x = x - 5 |
        -------------------------------------
        *=          | x *= 5    | x = x * 5 |
        -------------------------------------
        /=          | x /= 5    | x = x / 5 |
        -------------------------------------
        %=          | x %= 5    | x = x % 5 |
        -------------------------------------
        &=          | x &= 5    | x = x & 5 |
        -------------------------------------
        |=          | x |= 5    | x = x | 5 |
        -------------------------------------
        ^=          | x ^= 5    | x = x ^ 5 |
        -------------------------------------
        >>=         | x >>= 5   | x = x >> 5|
        -------------------------------------
        <<=         | x <<= 5   | x = x << 5|
        -------------------------------------
        */

        // Comparison Operators --------------------------------------------------------

        // Comparison operators are used to compare two values (or variables).
        // This is important in programming, because it helps us to find answers
        // and make decisions.

        // The return value of a comparison is either True or False. These values
        // are known as Boolean values, and you will learn more about them in the
        // Booleans and IfElse.

        // In the following example, we use the greater than operator (>) to find
        // out if 5 is greater than 3:

        int a = 5;
        int b = 3;
        System.Console.WriteLine(a > b);        // returns True because 5 is greater than 3.

        // A list of all comparison operators:

        /*
        -------------------------------------------
        Operator    | Name              | Example |
        -------------------------------------------
        ==          | Equal to          | x == y  |
        -------------------------------------------
        !=          | Not Equal         | x != y  |
        -------------------------------------------
        >           | Greater than      | x > y   |
        -------------------------------------------
        >           | Less than         | x < y   |
        -------------------------------------------
        >=          | Greater than or   | x >= y  |
                    | equal to          |         |
        -------------------------------------------
        <=          | Less than or      | x <= y  |
                    | equal to          |         |
        -------------------------------------------
         */

        // Logical Operators -----------------------------------------------------------

        // As with comparison operators, you can also test for True or False values
        // with logical operators.

        // Logical operators are used to determine the logic between variables or
        // values:

        /*
        -----------------------------------------------------------------------------
        Operator    | Name          | Description             | Example             |
        -----------------------------------------------------------------------------
        &&          | Logical and   | Returns True if both    | x < 5 && x < 10     |
                    |               | statements are true.    |                     |
        -----------------------------------------------------------------------------
        ||          | Logical or    | Returns True if one of  | x < 5 || x < 4      |
                    |               | the statements is true. |                     |
        -----------------------------------------------------------------------------
        !           | Logical not   | Reverse the result,     | !(x < 5 && x < 10)  |
                    |               | returns False if the    |                     |
                    |               | result is true.         |                     |
        -----------------------------------------------------------------------------
        */

        // See Booleans and IfElse for more info about comparison and logical operators.

    }
}