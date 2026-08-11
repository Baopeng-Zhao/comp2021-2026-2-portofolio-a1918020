class ToDo
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        while (true)
        {
            Console.Write("What would you like to do?");
            string? command = Console.ReadLine();
            
            switch (command)
            {
                case "add":
                Console.Write("what would you like to add?");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    tasks.Add(item);
                    Console.WriteLine($"Added: {item}");
                }
                else
                {
                    Console.WriteLine("Invalid task. Please try again.");
                }
                break;

                case "show":
                for(int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{tasks[i]}");
                }
                break;
            
                case "remove":
                Console.Write("Which task do you want to remove?");
                int index = int.Parse(Console.ReadLine());
                if(index < 1 || index > tasks.Count)
                {
                    Console.WriteLine("Invalid index. Please make a valid number.");
                    break;
                }
                tasks.RemoveAt(index-1);
                Console.WriteLine($"Removed task {index}");
                break;

                case "clear":
                tasks.Clear();
                Console.WriteLine("All tasks cleared.");
                break;

                case "exit":
                Console.WriteLine("Exiting the application.");
                return;

                default:
                Console.WriteLine("This is not a functional command. Please make command from add, show, remove and clear");
                break;
            }
        }
    }
}