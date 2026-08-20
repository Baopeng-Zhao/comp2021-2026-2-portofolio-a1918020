public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary{get;set;}
    
    public FullTimeEmployee(string name, decimal AnnualSalary)
    {
        this.name = name;
        this.AnnualSalary = AnnualSalary;
    }

    public override decimal CalculatePay()
    {
        decimal Tax = AnnualSalary * TaxRate;
        return AnnualSalary - Tax;
    }
    public string GenerateReport()
    {
        return $"Name:{name}, Annual Salary:{AnnualSalary}, Pay after tax:{CalculatePay()}";
    }
}