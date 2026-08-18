public class BankAccount
{
    public string Owner{get; set;}
    public double Balance{get; set;}

    public double Deposit(decimal amount)
    {
        return Balance += (double)amount;
    }
    public double Deposit(double amount)
    {
        return Balance += amount;
    }
    public double Deposit(int amount)
    {
        return Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (Balance >= (double)amount)
        {
            Balance -= (double) amount;
        }
        else
        {
            throw new InvalidOperationException("There are not enough balance in the account.");
        }
    }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }
}