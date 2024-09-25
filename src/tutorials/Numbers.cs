int a = 18;
int b = 6;
int c = 8;
int d = 5;
int e = 4;
int f = 2;
int g = 1;
int h = 7;
int i = 4;
int j = 3;

double[] numDoubles = [5, 4, 2, 19, 23, 8];

// ------------------------- Basic integer math -----------------------------
Console.WriteLine("--------- Basic integer math -----------");

// Plus
int result1 = a + b;
Console.WriteLine($"Plus: {result1}");
// Minus
result1 = a - b;
Console.WriteLine($"Minus: {result1}");
// Multiplication
result1 = a * b;
Console.WriteLine($"Multiplication: {result1}");
// Division
result1 = a / b;
Console.WriteLine($"Division: {result1}");
Console.WriteLine();


// C# is smart and can use correct order of operations
int result2 = d + e * f;
Console.WriteLine($"Correct order of operations: {result2}");


// You can force a different order of operations
result2 = (d + e) * f;
Console.WriteLine($"Forced order of operations: {result2}");


// Because of integer type, there will be no decimals
int result3 = (h + i) / j;
Console.WriteLine($"No decimals: {result3}");
Console.WriteLine();

// ----------------- ingerer precision and limits --------------------------

// You can get the remainder by using the remainder operator, the % character:
int result4 = (h + i) / j;
int result5 = (h + i) % j;
Console.WriteLine($"Quotient: {result4}");
Console.WriteLine($"Remainder: {result5}");
Console.WriteLine();

// Min Max limits of integer type
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition. 
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
Console.WriteLine();

// ----------------------------- Work with the double ----------------------

Console.WriteLine("------------- Work with the double ----------------------");
Console.WriteLine();
// Lets see some decimals
double result6 = (numDoubles[0] + numDoubles[1]) / numDoubles[2];   // (5+4)/2 = 4.5
Console.WriteLine(result6);

double result7 = (numDoubles[3] - numDoubles[4]) / numDoubles[5];   // (19+23)/8 = -0.5
Console.WriteLine(result7);

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

// Just like decimal numbers in math, doubles in C# can have rounding errors.
double third = 1.0 / 3.0;
Console.WriteLine(third);
Console.WriteLine();

// ----------------------------- Work with decimal --------------------------
Console.WriteLine("------------- Work with decimal ----------------------");
Console.WriteLine();

// The decimal type has a smaller range but greater precision than double.

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

// Notice that the range is smaller than the double type.
// You can see the greater precision with the decimal type by trying the following code:
double do1 = 1.0;
double do2 = 3.0;
Console.WriteLine(do1 / do2);

decimal de1 = 1.0M;
decimal de2 = 3.0M;
Console.WriteLine(de1 / de2);
Console.WriteLine();

// Write code that calculates the area of a circle whose radius is 2.50 centimeters.
// Remember that the area of a circle is the radius squared multiplied by PI

double radius = 2.50;
double area = Math.PI * radius * radius; // PI * r^2
Console.WriteLine(area);
Console.WriteLine();

// Math.Abs(x) ----------------------------------------------------------------
// The Math.Abs(x) method returns the absolute(positive) value of x:

Console.WriteLine(Math.Abs(-4.7));         // Returns 4.7