public class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Ian", 10000000000);
        Console.WriteLine($"Account Owner: {account.Owner}");
        Console.WriteLine($"Account Balance: {account.Balance}");
        Console.WriteLine("Depositing $500...");
        account.Deposit(500);
        Console.WriteLine($"Account Balance: {account.Balance}");
        Console.WriteLine("Withdrawing $200...");
        account.Withdraw(200);
        Console.WriteLine($"Account Balance: {account.Balance}");
    }
}