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