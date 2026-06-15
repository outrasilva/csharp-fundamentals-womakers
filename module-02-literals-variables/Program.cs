// Module 2 - Literals and Variables
// Concepts: string, char, int, decimal, bool, var, variable declaration

// Literal values
Console.WriteLine("Hello World!"); // string literal
Console.WriteLine('A'); // char literal
Console.WriteLine(123); // int literal
Console.WriteLine(12.39816m); // decimal literal
Console.WriteLine(true); // bool literal

// Variable declaration and initialization
string firstName = "Bob";
int age = 25;
decimal price = 9.99m;
bool isActive = true;

Console.WriteLine($"Name: {firstName}, Age: {age}, Price: {price}, Active: {isActive}");

// var keyword - compiler infers the type
var message = "Hello!";
var number = 42;

Console.WriteLine($"Message: {message}, Number: {number}");
