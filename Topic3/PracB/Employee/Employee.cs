public abstract class Employee
{
    public string name {get;set;} = "";

    public const decimal TaxRate = 0.2m;

    public abstract decimal CalculatePay();
}