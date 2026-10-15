using System.Diagnostics;
using System.Text.Json;

public class Program{
    public static void Main()
    {
        Player player1 = new Player("ian", 100, 10, 5);
        Player player2 = new Player("jack", 100, 10, 5);
        Player player3 = new Player("rusell", 100, 10, 5);
        Player player4 = new Player("sam", 100, 10, 5);
        Player player5 = new Player("tom", 100, 10, 5);

        LinkedList<Player> PlayerGroup = new LinkedList<Player>();
        PlayerGroup.AddLast(player1);
        PlayerGroup.AddLast(player2);
        PlayerGroup.AddLast(player3);
        PlayerGroup.AddLast(player4);
        PlayerGroup.AddLast(player5); 

        FileWriter<LinkedList<Player>>("jsonstring.json", PlayerGroup);
        LinkedList<Player> loadedPlayers = FileReader<LinkedList<Player>>("jsonstring.json");

        foreach(Player player in loadedPlayers)
        {
            Console.WriteLine($"{player.Name}: health={player.Health}, attack={player.Attack}, defence={player.Defence}");
        }

        GC.Collect();
        long headSize = GC.GetGCMemoryInfo().HeapSizeBytes;
        Console.WriteLine($"The heap size is: {headSize}");
        long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;
        Console.WriteLine($"Peek Memory is: {peakMemory}");
    }
    
    public static void FileWriter<T>(string path, T objectToWrite) where T : class
    {
        string jsonString = JsonSerializer.Serialize(objectToWrite);
        File.WriteAllText(path, jsonString);
    }
    public static T FileReader<T>(string path) where T : class
    {
        string jsonString = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(jsonString)!;
    }
}