public class Contractor: Employee, IReportable
{
    public decimal Rate{get;set;}
    public decimal Hours{get;set;}
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