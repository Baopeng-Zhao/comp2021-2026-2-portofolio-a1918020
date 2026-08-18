public class Program
{
    static void Main()
    {
       SavingsAccount savings = new SavingsAccount("ian", 10000, 0.05);
       Console.WriteLine("Saving Account");
       Console.WriteLine($"Owner: {savings.Owner}");
       Console.WriteLine($"Balance before interest: ${savings.Balance}");
       savings.ApplyInterest();
       Console.WriteLine($"Balance after interest: ${savings.Balance}");
       Console.WriteLine();
       CheckingAccount checking = new CheckingAccount("yufei", 1000, 5);
       Console.WriteLine();
       Console.WriteLine("Checking Account");
       Console.WriteLine($"Owner: {checking.Owner}");
       Console.WriteLine($"Balance before withdrawal: ${checking.Balance}");
       checking.Withdraw(100);
       Console.WriteLine($"Balance after withdrawing $100 with $5 fee: ${checking.Balance}");
    }
}