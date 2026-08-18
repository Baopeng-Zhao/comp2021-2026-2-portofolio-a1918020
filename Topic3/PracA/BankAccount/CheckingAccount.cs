using System.Transactions;

public class CheckingAccount : BankAccount
{
    public double TransactionFee {get;set;}
    public CheckingAccount(string owner, double balance, double transactionFee): base(owner, balance)
    {
        TransactionFee = transactionFee;
    }
    
    public override void Withdraw(decimal amount)
    {
        Balance -= (double)amount + TransactionFee;
    }
}