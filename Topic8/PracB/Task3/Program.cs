using System.Text.Json;

public class Program{
    public static void Main()
    {
        Player player1 = new Player("ian", 100, 10, 5);
        Player player2 = new Player("jack", 100, 10, 5);
        Player player3 = new Player("rusell", 100, 10, 5);
        Player player4 = new Player("sam", 100, 10, 5);
        Player player5 = new Player("tom", 100, 10, 5);

        List<Player> PlayerGroup = new List<Player>();
        PlayerGroup.Add(player1);
        PlayerGroup.Add(player2);
        PlayerGroup.Add(player3);
        PlayerGroup.Add(player4);
        PlayerGroup.Add(player5); 

        FileWriter<List<Player>>("jsonstring.json", PlayerGroup);
        List<Player> loadedPlayers = FileReader<List<Player>>("jsonstring.json");

        foreach(Player player in loadedPlayers)
        {
            Console.WriteLine($"{player.Name}: health={player.Health}, attack={player.Attack}, defence={player.Defence}");
        }
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