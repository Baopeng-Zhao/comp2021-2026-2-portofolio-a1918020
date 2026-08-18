using Xunit;

public class BankAccountTests
{
    [Fact]
    public void Constructor_ShouldSetOwnerAndBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);

        Assert.Equal("Ian", account.Owner);
        Assert.Equal(1000, account.Balance);
    }

    [Fact]
    public void Deposit_ShouldIncreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);

        account.Deposit(500);

        Assert.Equal(1500, account.Balance);
    }

    [Fact]
    public void Withdraw_ShouldDecreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);

        account.Withdraw(200m);

        Assert.Equal(800, account.Balance);
    }
}

public class SavingsAccountTests
{
    [Fact]
    public void Constructor_ShouldSetOwnerAndBalance()
    {
        SavingsAccount account =
            new SavingsAccount("Ian", 1000, 0.05);

        Assert.Equal("Ian", account.Owner);
        Assert.Equal(1000, account.Balance);
    }

    [Fact]
    public void InterestRate_ShouldBeSet()
    {
        SavingsAccount account =
            new SavingsAccount("Ian", 1000, 0.05);

        Assert.Equal(0.05, account.InterestRate);
    }

    [Fact]
    public void ApplyInterest_ShouldIncreaseBalance()
    {
        SavingsAccount account =
            new SavingsAccount("Ian", 1000, 0.05);

        account.ApplyInterest();

        Assert.Equal(1050, account.Balance);
    }

    [Fact]
    public void DisplayAccountInfo_ShouldRun()
    {
        SavingsAccount account =
            new SavingsAccount("Ian", 1000, 0.05);

        account.DisplayAccountInfo();
    }

    public class CheckingAccountTests
{
    [Fact]
    public void Constructor_ShouldSetOwnerBalanceAndFee()
    {
        CheckingAccount account =
            new CheckingAccount("Ian", 1000, 5);

        Assert.Equal("Ian", account.Owner);
        Assert.Equal(1000, account.Balance);
        Assert.Equal(5, account.TransactionFee);
    }

    [Fact]
    public void Withdraw_ShouldDeductAmountAndTransactionFee()
    {
        CheckingAccount account =
            new CheckingAccount("Ian", 1000, 5);

        account.Withdraw(100m);

        Assert.Equal(895, account.Balance);
    }

    [Fact]
    public void DisplayAccountInfo_ShouldRun()
    {
        CheckingAccount account =
            new CheckingAccount("Ian", 1000, 5);

        account.DisplayAccountInfo();
    }
}
}