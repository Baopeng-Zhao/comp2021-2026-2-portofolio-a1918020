public class Contractor: Employee, IReportable
{
    public decimal Rate{get;set;}
    public decimal Hours{get;set;}
    
    public Contractor(string name, decimal rate, decimal hours)
    {
        this.name = name;
        Rate = rate;
        Hours = hours;
    }
    public override decimal CalculatePay()
    {
        decimal Tax = Rate*Hours*TaxRate;
        return (Rate * Hours)- Tax;
    }
    public string GenerateReport()
    {
        return $"Rate:{Rate}, Hours:{Hours}, Pay after Tax:{CalculatePay()}";
    }
}