// Challenge 2 - Cumulative Calculator
// Concepts: do-while + switch + double + type conversion
// Each operation starts from the previous result
// R to reset, S to quit

using System;

public class Program
{
    public static void Main()
    {
        double resultado = 0;
        string? operador = null;

        do
        {
            Console.WriteLine($"Current result: {resultado}");
            Console.Write("Operator (+, -, *, /, R to reset, S to quit): ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.Write("Number: ");
                    double numero = double.Parse(Console.ReadLine());
                    resultado += numero;
                    break;
                case "-":
                    Console.Write("Number: ");
                    numero = double.Parse(Console.ReadLine());
                    resultado -= numero;
                    break;
                case "*":
                    Console.Write("Number: ");
                    numero = double.Parse(Console.ReadLine());
                    resultado *= numero;
                    break;
                case "/":
                    Console.Write("Number: ");
                    numero = double.Parse(Console.ReadLine());
                    resultado /= numero;
                    break;
                case "R":
                    resultado = 0;
                    break;
            }
        } while (operador != "S");
    }
}