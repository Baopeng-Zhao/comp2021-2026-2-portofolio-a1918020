class Program
{
    static void Main()
    {
        FullTimeEmployee employee = new FullTimeEmployee();

        employee.name = "John";
        employee.AnnualSalary = 100000m;

        Contractor contractor = new Contractor();

        contractor.name = "Tom";
        contractor.Rate = 50m;
        contractor.Hours = 100m;

        Console.WriteLine("Full Time Employee:");
        Console.WriteLine(employee.GenerateReport());
        Console.WriteLine($"Calculate Pay: {employee.CalculatePay()}");

        Console.WriteLine();

        Console.WriteLine("Contractor:");
        Console.WriteLine(contractor.GenerateReport());
        Console.WriteLine($"Calculate Pay: {contractor.CalculatePay()}");
    }
}