using System.Text.Json;
using System.Diagnostics;

public class Program
{
    // public static void Main()
    // {
    //     List<Player> players1 = new List<Player>();

    //     for(int i = 0; i < 10000; i++)
    //     {
    //         Player player = new Player("name" + i, 100, 10, 5);
    //         players1.Add(player);
    //     }

    //     FileWriter<List<Player>>("list.json", players1);

    //     List<Player> loadedPlayers1 =
    //         FileReader<List<Player>>("list.json");

    //     GC.Collect();

    //     long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
    //     long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

    //     Console.WriteLine($"List Heap Size: {heapSize} bytes");
    //     Console.WriteLine($"List Peak Memory: {peakMemory} bytes");

    //     GC.KeepAlive(players1);
    //     GC.KeepAlive(loadedPlayers1);
    // }

    public static void FileWriter<T>(string path, T objectToWrite)
        where T : class
    {
        string jsonString = JsonSerializer.Serialize(objectToWrite);
        File.WriteAllText(path, jsonString);
    }

    public static T FileReader<T>(string path)
        where T : class
    {
        string jsonString = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(jsonString)!;
    }

     public static void Main()
{
    LinkedList<Player> players2 = new LinkedList<Player>();

    for(int i = 0; i < 10000; i++)
    {
        Player player = new Player("name" + i, 100, 10, 5);
        players2.AddLast(player);
    }

    FileWriter<LinkedList<Player>>("Linkedlist.json", players2);

    LinkedList<Player> loadedPlayers2 =
        FileReader<LinkedList<Player>>("Linkedlist.json");

    GC.Collect();

    long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
    long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

    Console.WriteLine($"LinkedList Heap Size: {heapSize} bytes");
    Console.WriteLine($"LinkedList Peak Memory: {peakMemory} bytes");

    GC.KeepAlive(players2);
    GC.KeepAlive(loadedPlayers2);
}

}