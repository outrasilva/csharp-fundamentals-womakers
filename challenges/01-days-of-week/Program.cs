// Challenge 1 - Days of the Week
// Concepts: string array + foreach
// Store the days of the week in an array and display them one per line

using System;

public class Program
{
    public static void Main()
    {
        string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        foreach (string day in daysOfWeek)
        {
            Console.WriteLine(day);
        }
    }
}