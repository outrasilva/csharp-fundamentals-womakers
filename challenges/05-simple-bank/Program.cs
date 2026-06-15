// Challenge 5 - Simple Bank System
// Concepts: do-while + switch + if (withdrawal limit)
// Menu: show balance, deposit, withdraw, quit

using System;

public class Program
{
    public static void Main()
    {
        double saldo = 0;
        double valorDepositado = 0;
        double valorSacado = 0;
        string? opcao = null;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Show balance");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            Console.WriteLine("4 - Quit");
            Console.Write("Option: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Current balance: R$ {saldo}");
                    break;
                case "2":
                    Console.Write("Deposit amount: ");
                    valorDepositado = double.Parse(Console.ReadLine());
                    saldo += valorDepositado;
                    Console.WriteLine($"Current balance: R$ {saldo}");
                    break;
                case "3":
                    Console.Write("Withdrawal amount: ");
                    valorSacado = double.Parse(Console.ReadLine());
                    if (valorSacado > saldo)
                        Console.WriteLine("Insufficient balance!");
                    else
                    {
                        saldo -= valorSacado;
                        Console.WriteLine($"Current balance: R$ {saldo}");
                    }
                    break;
            }
        } while (opcao != "4");

        Console.WriteLine("Goodbye!");
    }
}