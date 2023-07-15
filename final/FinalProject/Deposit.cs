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