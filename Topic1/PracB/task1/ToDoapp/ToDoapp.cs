using System.Transactions;

class ToDo
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();
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

                case"tag":
                Console.Write("Enter index: ");
                int tagIndex;

                if (!int.TryParse(Console.ReadLine(), out tagIndex) ||
                    tagIndex < 0 || tagIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid index.");
                    break;
                }

                Console.Write("Enter tag: ");
                string tagName = Console.ReadLine() ?? "";

                if (!tags.ContainsKey(tagName))
                {
                    tags[tagName] = new List<int>();
                }

                if (tags[tagName].Contains(tagIndex))
                {
                    Console.WriteLine("Tag already added.");
                    break;
                }

                tags[tagName].Add(tagIndex);
                Console.WriteLine("Tag added.");
                break;

                case"get-tagged":
                Console.Write("Enter tag: ");
                string searchTag = Console.ReadLine() ?? "";

                if (!tags.ContainsKey(searchTag))
                {
                    Console.WriteLine("Tag not found.");
                    break;
                }

                foreach (int taskIndex in tags[searchTag])
                {
                    Console.WriteLine($"{taskIndex}: {tasks[taskIndex]}");
                }
                break;

                default:
                Console.WriteLine("This is not a functional command. Please make command from add, show, remove and clear");
                break;
            }
        }
    }
}