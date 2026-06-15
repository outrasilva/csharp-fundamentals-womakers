// Module 3 - Basic Operations on Numbers
// Concepts: +, -, *, /, %, cast, order of operations, implicit conversion

// Basic math operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5; // truncates decimal

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient (int): {quotient}");

// Decimal division
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// Cast - temporarily convert int to decimal
int first = 7;
int second = 5;
decimal result = (decimal)first / (decimal)second;
Console.WriteLine($"Cast result: {result}");

// Modulus operator - remainder of division
Console.WriteLine($"7 % 5 = {7 % 5}"); // 2
Console.WriteLine($"10 % 5 = {10 % 5}"); // 0 (divisible!)

// Order of operations (PEMDAS)
int value1 = 3 + 4 * 5; // 23 - multiplication first
int value2 = (3 + 4) * 5; // 35 - parentheses first
Console.WriteLine($"Without parentheses: {value1}");
Console.WriteLine($"With parentheses: {value2}");

// Implicit conversion - string + int
string name = "Bob";
int widgets = 7;
Console.WriteLine(name + " sold " + (widgets + 7) + " widgets.");

// Fahrenheit to Celsius challenge
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5.0m / 9.0m);
Console.WriteLine($"The temperature is {celsius} Celsius.");