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