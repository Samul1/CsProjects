// Output a message to console
Console.WriteLine("Hello world!");
// Empty line in console window
Console.WriteLine();
// -------------------------------- Work With String ---------------------------------------

Console.WriteLine("----------- Basic String Stuff: -------------------");
Console.WriteLine();

// String variable
string[] strings = ["Juho", "Paula", "        Hello World        ", "3", "4", "5"];
Console.WriteLine(strings[0]);

// You can use string type variables in console printing
Console.WriteLine("My friend is: " + strings[0]);
// Can also be done like this
Console.WriteLine($"My friend is: {strings[0]}");

// You can also use multible string variables in sentence.
Console.WriteLine($"My friend is {strings[0]} and my fiance is {strings[1]}.");

// You can see what is string length
Console.WriteLine($"Name '{strings[1]}' has {strings[1].Length} letters.");

// --------------------------------- Upper and Lower cases -----------------------------

Console.WriteLine();
Console.WriteLine("------------- Upper and Lower cases -----------------");
Console.WriteLine();

// You also can put all letter to lower or upper cases
Console.WriteLine($"{strings[1]} {strings[1].ToLower()} {strings[1].ToUpper()}");
Console.WriteLine();

// --------------------------------- Trim:ing -----------------------------------------
Console.WriteLine("------------------ Trimming: --------------------- ");
Console.WriteLine();

// Too many spaces
Console.WriteLine($"{strings[2]}");

// So lets trim empty spaces
Console.WriteLine($"[{strings[2].TrimStart()}]");
Console.WriteLine($"[{strings[2].TrimEnd()}]");
Console.WriteLine($"[{strings[2].Trim()}]");
Console.WriteLine();

// -------------------------------- Replace -------------------------------------------

Console.WriteLine(" ----------------- Replace: -------------------------");

// This method takes too variables and replaces first with second
strings[3] = "Hello there!";
Console.WriteLine(strings[3]);
strings[3] = strings[3].Replace("Hello there!", "Greetings!");
Console.WriteLine(strings[3]);
Console.WriteLine();

// ------------------------------- Search string ---------------------------------------

Console.WriteLine("-------------- Search string -------------------------");

strings[4] = "Say something I'm giving up on you";
// .Contains return true or false if string contains a substring inside it
Console.WriteLine(strings[4].Contains("giving"));   // True
Console.WriteLine(strings[4].Contains("meet"));     // False

// .StartsWith search if the string start with searchword
Console.WriteLine(strings[4].StartsWith("Say"));    // True
Console.WriteLine(strings[4].StartsWith("They"));   // False
// .EndsWith search if the string end with searchword
Console.WriteLine(strings[4].EndsWith("you"));      // True
Console.WriteLine(strings[4].EndsWith("me"));       // False