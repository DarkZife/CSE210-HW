using System;
using System.Collections.Generic;

public abstract class Account
{
    private string accountNumber;
    private double balance;
    private List<string> transactionHistory;

    public Account(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
        this.transactionHistory = new List<string>();
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        balance += amount;
        transactionHistory.Add($"Deposit: +${amount}");
    }

    public virtual void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            transactionHistory.Add($"Withdrawal: -${amount}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: ${balance}");
    }

    public void DisplayTransactionHistory()
    {
        Console.WriteLine($"Transaction History for Account: {accountNumber}");
        foreach (string transaction in transactionHistory)
        {
            Console.WriteLine(transaction);
        }
    }
}

// Deposit class
public class Deposit
{
    public static void Execute(Account account)
    {
        Console.Write("Enter the amount to deposit: $");
        double depositAmount = double.Parse(Console.ReadLine());
        account.Deposit(depositAmount);
        Console.WriteLine("Deposit successful.");
    }
}

// Withdraw class
public class Withdraw
{
    public static void Execute(Account account)
    {
        Console.Write("Enter the amount to withdraw: $");
        double withdrawAmount = double.Parse(Console.ReadLine());
        account.Withdraw(withdrawAmount);
        Console.WriteLine("Withdrawal successful.");
    }
}

// CheckBalance class
public class CheckBalance
{
    public static void Execute(Account account)
    {
        account.DisplayBalance();
    }
}

// CheckHistory class
public class CheckHistory
{
    public static void Execute(Account account)
    {
        account.DisplayTransactionHistory();
    }
}

// Checking account class
public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber) : base(accountNumber)
    {
    }

    public override void Withdraw(double amount)
    {
        base.Withdraw(amount);
    }
}

// Savings account class
public class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber) : base(accountNumber)
    {
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= 5) // Minimum balance requirement for savings account
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Withdrawal amount exceeds minimum balance requirement.");
        }
    }
}

// Credit loan account class
public class CreditLoanAccount : Account
{
    public CreditLoanAccount(string accountNumber) : base(accountNumber)
    {
    }

    public override void Withdraw(double amount)
    {
        base.Withdraw(amount);
    }
}

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
