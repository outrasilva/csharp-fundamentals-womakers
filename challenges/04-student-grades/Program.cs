// Challenge 4 - Student Grade System
// Concepts: variables, double, math operations, if/else if/else, array, for
// Calculate average from 3 grades and display the result

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter student name: ");
        string nome = Console.ReadLine();

        double[] notas = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter grade {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double media = (notas[0] + notas[1] + notas[2]) / 3;
        Console.Write($"Average of {nome}: {media:F2} - ");

        if (media >= 7)
            Console.WriteLine("Approved");
        else if (media >= 4.5)
            Console.WriteLine("Recovery");
        else
            Console.WriteLine("Failed");
    }
}