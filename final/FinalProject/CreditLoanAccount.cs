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