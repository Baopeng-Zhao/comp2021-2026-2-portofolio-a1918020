var SortedScores = new SortedDictionary<int, string>();
SortedScores.Add(1, "Alice");
SortedScores.Add(14, "JACK");
SortedScores.Add(17, "Yufei");
SortedScores.Add(91, "Ian");
SortedScores.Add(56, "Bob");
SortedScores.Add(12, "Tom");
SortedScores.Add(18, "Sam");
SortedScores.Add(61, "Rusell");
SortedScores.Add(41, "Amy");
SortedScores.Add(38, "Jerry");

foreach(var player in SortedScores.Take(3))
{
    Console.WriteLine($"{player.Key}: {player.Value}");
}

Console.WriteLine("");

foreach(var player in SortedScores.TakeLast(3))
{
    Console.WriteLine($"{player.Key}: {player.Value}");
}

SortedScores.Add(60,"Ian");
SortedScores.Add(61,"noname");