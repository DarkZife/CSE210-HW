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