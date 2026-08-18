public class SavingsAccount : BankAccount
{
    public double InterestRate {get;set;}
    public SavingsAccount(string owner, double balance, double interestRate): base(owner, balance)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        double interest = Balance * InterestRate;
        Deposit(interest);
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: SavingsAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: ${Balance}");
        Console.WriteLine($"Interest rate: {InterestRate * 100}%");
    }
}