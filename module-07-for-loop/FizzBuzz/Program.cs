// Module 7 - for loop
// Concepts: for (initializer, condition, iterator), break, array iteration, modulus

// Basic for loop
for (int i = 0; i < 10; i++)
    Console.WriteLine(i);

// Countdown
for (int i = 10; i >= 0; i--)
    Console.WriteLine(i);

// Skip values (increment by 3)
for (int i = 0; i < 10; i += 3)
    Console.WriteLine(i);

// Iterate array backwards (not possible with foreach)
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
    Console.WriteLine(names[i]);

// Modify array elements (not possible with foreach)
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
        names[i] = "Sammy";
}

foreach (var name in names)
    Console.WriteLine(name);

// FizzBuzz challenge - for + if + % operator
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine(i);
}