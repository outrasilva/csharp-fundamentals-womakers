// Challenge 3 - Odd and Even numbers from 1 to 100
// Concepts: for loop + % (modulus operator)
// Display even numbers first, then odd numbers

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Even:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\nOdd:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }
    }
}