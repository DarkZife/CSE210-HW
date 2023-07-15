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