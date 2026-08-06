class Program
{
    static void Main()
    {
        Person person = new Person("BaoPeng", "Zhao", 18);
        Console.WriteLine($"Full Name:{person.FullName()}");
        Console.WriteLine($"Is adult:{person.IsAdult()}");
    }
}