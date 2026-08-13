class Program
{
    const double TAX_RATE=0.2;

    static double CalculatePay(double hours, double rate)
    {
        if (hours < 0 || rate < 0)
        {
            throw new ArgumentException("Hours and rate must be positive.");
        }
        double gross = hours * rate;
        double tax = gross * TAX_RATE;
        double net = gross - tax;
        return net;
    }

    static void Main()
    {
        try
        {
        Console.Write("Enter employee name: ");
        string? name = Console.ReadLine();
        Console.Write("Hours worked: ");
        double hours = double.Parse(Console.ReadLine()??"");
        Console.Write("Hourly rate: ");
        double rate = double.Parse(Console.ReadLine()??"");
        double netPay = CalculatePay(hours, rate);
        Console.WriteLine($"{name} earned ${netPay:F2} after tax.");

        Person person = new Person("Baopeng", "Zhao", 21);
        Console.WriteLine($"Full Name: {person.FullName()}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Is Adult: {person.IsAdult()}");

    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid number entered. ");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");                           
    }
    }
}


