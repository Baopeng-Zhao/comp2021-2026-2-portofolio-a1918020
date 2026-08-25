public static class BrokenProgram
{
    static void Main(string[] args)
    {
        const string input = """
       23
       + 
       77
       + 
        3
       + 
      457
       * 
        2
      """;
        int total = 0;
        List<int> items = [];
        List<string> symbols = [];
        string clearedInput = input.Replace("\r","");

        for (int i = 0; i < clearedInput.Split("\n").Length; i += 2)
        {
            items.Add(int.Parse(clearedInput.Substring(i * 4, 3)));

            if (i != 0)
            {
                symbols.Add(clearedInput.Split("\n")[i - 1]);
            }
        }

        foreach (var (i, value) in items.Index())
        {
            if (i == 0) { total = value; }
            else if (symbols[i - 1] == " * ")
            {
                total *= value;
            }
            else
            {
                total += value;
            }
        }
        Console.WriteLine("Total was: " + total);
        Console.WriteLine("Expected total was: 1120");
        Console.WriteLine(total == 1120 ? "Your answer was RIGHT!" : "Your answer was WRONG!\nGo and fix it.");
    }
}