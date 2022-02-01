using System;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] bankAccounts = new BankAccount[100];
            bool choice = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to ABC Bank");
                Console.WriteLine("1. Create a new bank account");
                Console.WriteLine("2. Search bank account");
                Console.WriteLine("3. Pay In to bank account");
                Console.WriteLine("4. Withdraw from a bank account");
                Console.WriteLine("5. Change a bank account status");
                Console.WriteLine("#. Select you option");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter account details");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter account code");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter account code");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter account code");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Enter account code");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Thanks for using our application...!");
                        Console.ReadKey();
                        choice = false;
                        break;
                }
            } while (choice);
        }
    }
}