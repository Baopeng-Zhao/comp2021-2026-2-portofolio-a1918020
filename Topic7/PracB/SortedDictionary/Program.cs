using System.Linq.Expressions;

var SortedScores2 = new SortedDictionary<ScoreEntry, Player>(new ScoreComparer());
Player player1 = new Player("ian", 100, 10, 5);
Player player2 = new Player("Alice", 100, 10, 5);
Player player3 = new Player("Jack", 100, 10, 5);
Player player4 = new Player("Rusell", 100, 10, 5);
Player player5 = new Player("Bob", 100, 10, 5);
Player player6 = new Player("Yufei", 100, 10, 5);
Player player7 = new Player("Aroosh", 100, 10, 5);
Player player8 = new Player("Tom", 100, 10, 5);
Player player9 = new Player("Sam", 100, 10, 5);
Player player10 = new Player("John", 100, 10, 5);

ScoreEntry player1Score = new ScoreEntry(100, 2, DateTime.Now);
ScoreEntry player2Score = new ScoreEntry(10, 1, DateTime.Now);
ScoreEntry player3Score = new ScoreEntry(1, 1, DateTime.Now);
ScoreEntry player4Score = new ScoreEntry(1000, 3, DateTime.Now);
ScoreEntry player5Score = new ScoreEntry(101, 2, DateTime.Now);
ScoreEntry player6Score = new ScoreEntry(15, 1, DateTime.Now);
ScoreEntry player7Score = new ScoreEntry(12, 1, DateTime.Now);
ScoreEntry player8Score = new ScoreEntry(1200, 3, DateTime.Now);
ScoreEntry player9Score = new ScoreEntry(10000, 4, DateTime.Now);
ScoreEntry player10Score = new ScoreEntry(13, 1, DateTime.Now);

SortedScores2.Add(player1Score, player1);
SortedScores2.Add(player2Score, player2);
SortedScores2.Add(player3Score, player3);
SortedScores2.Add(player4Score, player4);
SortedScores2.Add(player5Score, player5);
SortedScores2.Add(player6Score, player6);
SortedScores2.Add(player7Score, player7);
SortedScores2.Add(player8Score, player8);
SortedScores2.Add(player9Score, player9);
SortedScores2.Add(player10Score, player10);

Console.WriteLine("Here are Top3");
Console.WriteLine("");

foreach(var player in SortedScores2.Take(3))
{
    Console.WriteLine($"{player.Key}: {player.Value}");
}

Console.WriteLine("Here are Last3: ");
Console.WriteLine("");

foreach(var player in SortedScores2.TakeLast(3))
{
    Console.WriteLine($"{player.Key}: {player.Value}");
}

Console.WriteLine("Aftering moving player Yufei: ");
Console.WriteLine("");

SortedScores2.Remove(player6Score);

foreach(var player in SortedScores2)
{
    Console.WriteLine($"{player.Key}: {player.Value}");
}

Player player11 = new Player("noname", 100, 10, 5);
ScoreEntry player11Score = new ScoreEntry(13, 2, DateTime.Now);
SortedScores2.Add(player11Score, player11);

Player player12 = new Player("noname", 100, 10, 5);
ScoreEntry player12Score = new ScoreEntry(13, 2, DateTime.Now);
SortedScores2.Add(player12Score, player12);