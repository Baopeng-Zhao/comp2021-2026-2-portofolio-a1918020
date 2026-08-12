public class UnitTest1
{
    [Fact]
    public void Constructor_validValues()
    {
        Payroll payroll = new Payroll(10, 20m, 0.2m);
        decimal result = payroll.CalculateNetPay();
        Assert.Equal(160m, result);
    }

    [Fact]
    public void Constructor_NegativeHours_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Payroll(-1, 20m, 0.2m));
    }

    [Fact]
    public void Constructor_NegativeRate_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Payroll(10, -20m, 0.2m));
    }

    [Fact]
    public void Constructor_NegativeTaxRate_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Payroll(10, 20m, -0.2m));
    }

    [Fact]
    public void ChangeTaxRate_ValidValue()
    {
        Payroll payroll = new Payroll(10, 20m, 0.2m);
        payroll.ChangeTaxRate(0.1m);
        decimal result = payroll.CalculateNetPay();
        Assert.Equal(180m, result);
    }

    [Fact]
    public void ChangeTaxRate_NegativeValue_ThrowsException()
    {
        Payroll payroll = new Payroll(10, 20m, 0.2m);
        Assert.Throws<ArgumentException>(() => payroll.ChangeTaxRate(-0.1m));
    }

}