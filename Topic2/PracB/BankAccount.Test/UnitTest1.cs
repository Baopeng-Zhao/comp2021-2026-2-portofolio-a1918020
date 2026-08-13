public class BankAccountTests
{
    [Fact]
    public void BankAccount_InitializesAccount()
    {
        BankAccount account = new BankAccount("Ian", 1000);
        Assert.Equal("Ian", account.Owner);
        Assert.Equal(1000, account.Balance);
    }
    [Fact]
    public void DepositDecimal_ShouldIncreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);
        account.Deposit(100m);
        Assert.Equal(1100, account.Balance);
    }
    [Fact]
    public void DepositDouble_ShouldIncreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);
        account.Deposit(100.0);
        Assert.Equal(1100, account.Balance);
    }
    [Fact]
    public void DepositInt_ShouldIncreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);
        account.Deposit(100);
        Assert.Equal(1100, account.Balance);
    }
    [Fact]
    public void Withdraw_ShouldDecreaseBalance()
    {
        BankAccount account = new BankAccount("Ian", 1000);
        account.Withdraw(200);
        Assert.Equal(800, account.Balance);
    }
    [Fact]
    public void Withdraw_ShouldThrowException_WhenNotEnoughBalance()
    {
        BankAccount account = new BankAccount("Ian", 100);
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
        Assert.Equal("There are not enough balance in the account.", exception.Message);
    }
}
