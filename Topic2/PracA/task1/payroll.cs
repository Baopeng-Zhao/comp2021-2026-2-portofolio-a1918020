class Payroll
{
    private double hours;
    private decimal rate;
    private decimal taxRate;

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        if (hours < 0 || rate < 0 || taxRate < 0)
        {
            throw new ArgumentException(
                "Hours, rate and tax rate should be positive."
            );
        }
        this.hours = hours;
        this.rate = rate;
        this.taxRate = taxRate;
    }
    
    public decimal CalculateNetPay()
    {
        decimal gross = (decimal)hours * rate;
        decimal tax = gross * taxRate;
        decimal net = gross - tax;
        return net;
    }

    public void ChangeTaxRate(decimal newTaxRate)
    {
        if(newTaxRate < 0)
        {
            throw new ArgumentException("Tax rate should be positive.");
        }
        taxRate = newTaxRate;
    }
}