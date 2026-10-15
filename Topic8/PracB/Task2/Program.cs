using System.Text.Json;

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

string jsonString = JsonSerializer.Serialize(PlayerGroup);
Console.WriteLine(jsonString);
File.WriteAllText("jsonstring.json", jsonString);
List<Player> loadedPlayers = JsonSerializer.Deserialize<List<Player>>(jsonString)!;