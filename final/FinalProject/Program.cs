using System;
using System.Collections.Generic;

// Program class
public class Program
{
    public static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayMainMenu();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ProcessAccountMenu(new CheckingAccount("CH01"));
                    break;
                case "2":
                    ProcessAccountMenu(new SavingsAccount("SA01"));
                    break;
                case "3":
                    ProcessAccountMenu(new CreditLoanAccount("CL01"));
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private static void DisplayMainMenu()
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("Please select an account type:");
        Console.WriteLine("1. Checking Account");
        Console.WriteLine("2. Savings Account");
        Console.WriteLine("3. Credit Loan Account");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    private static void ProcessAccountMenu(Account account)
    {
        bool exit = false;
        while (!exit)
        {
            DisplayAccountMenu();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Deposit.Execute(account);
                    break;
                case "2":
                    Withdraw.Execute(account);
                    break;
                case "3":
                    CheckBalance.Execute(account);
                    break;
                case "4":
                    CheckHistory.Execute(account);
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Returning to main menu.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayAccountMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Account Menu:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check Balance");
        Console.WriteLine("4. Check Transaction History");
        Console.WriteLine("5. Return to Main Menu");
        Console.Write("Enter your choice: ");
    }
}
