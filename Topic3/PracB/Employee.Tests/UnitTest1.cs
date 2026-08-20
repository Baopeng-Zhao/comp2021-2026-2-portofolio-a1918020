public class UnitTest1
{
  [Fact]
    public void FullTimeEmployee_Constructor()
    {
        FullTimeEmployee employee = new FullTimeEmployee("John", 100000m);

        Assert.Equal("John", employee.name);
        Assert.Equal(100000m, employee.AnnualSalary);
    }

    [Fact]
    public void FullTimeEmployee_CalculatePay()
    {
        FullTimeEmployee employee =
        new FullTimeEmployee("John", 100000m);

        decimal result = employee.CalculatePay();

        Assert.Equal(80000m, result);
    }

    [Fact]
    public void FullTimeEmployee_GenerateReport()
    {
        FullTimeEmployee employee =
        new FullTimeEmployee("John", 100000m);

        string result = employee.GenerateReport();

        Assert.Contains("John", result);
        Assert.Contains("100000", result);
        Assert.Contains("80000", result);
    }

    [Fact]
    public void Contractor_Constructor()
    {
        Contractor contractor =
        new Contractor("Fred", 50m, 100m);

        Assert.Equal("Fred", contractor.name);
        Assert.Equal(50m, contractor.Rate);
        Assert.Equal(100m, contractor.Hours);
    }

    [Fact]
    public void Contractor_CalculatePay()
    {
        Contractor contractor =
        new Contractor("Fred", 50m, 100m);

        decimal result = contractor.CalculatePay();

        Assert.Equal(4000m, result);
    }

    [Fact]
    public void Contractor_GenerateReport()
    {
        Contractor contractor =
        new Contractor("Fred", 50m, 100m);

        string result = contractor.GenerateReport();

        Assert.Contains("50", result);
        Assert.Contains("100", result);
        Assert.Contains("4000", result);
    }
}
