class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter hours worked: ");
            double hours = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Enter hourly rate: ");
            decimal rate = decimal.Parse(Console.ReadLine() ?? "");
            decimal taxRate = 0.2m;

            Payroll payroll = new Payroll(hours, rate, taxRate);

            decimal net = payroll.CalculateNetPay();

            Console.WriteLine($"{name} earned ${net:F2} after tax.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}