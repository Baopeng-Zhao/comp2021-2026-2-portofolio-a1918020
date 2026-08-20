class Program
{
    static void Main()
    {
        FullTimeEmployee employee1 = new FullTimeEmployee("John", 100000m);

        Contractor contractor = new Contractor("Tom", 50m, 100m);

        Console.WriteLine("Full Time Employee:");
        Console.WriteLine(employee1.GenerateReport());
        Console.WriteLine($"Calculate Pay: {employee1.CalculatePay()}");

        Console.WriteLine();

        Console.WriteLine("Contractor:");
        Console.WriteLine(contractor.GenerateReport());
        Console.WriteLine($"Calculate Pay: {contractor.CalculatePay()}");

        Console.WriteLine("");

        List<Employee> employees = new List<Employee>();
        employees.Add(new FullTimeEmployee("Yufei", 6000m));
        employees.Add(new Contractor("Ian", 50m, 50m));
        foreach(Employee employee in employees)
        {
            decimal Pay = employee.CalculatePay();
            decimal totalPay = Pay/0.8m;
            decimal Tax = Pay*0.2m;
            Console.WriteLine($"{employee.name}: Pay: ${Pay}. Tax ${Tax}");
        }
    }
}