using System.IO.Compression;

void DisplayScores(SortedSet<int> scores)
{
    int lowest = scores.ElementAt(1);
    int highest = scores.ElementAt(1);
    foreach (int score in scores)
    {
        Console.WriteLine(score);
        if(score > highest)
        {
            highest = score;
        }

        if(score < lowest)
        {
            lowest = score;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The highest score is: {highest}");
    Console.WriteLine($"The lowest score is: {lowest}");
}

SortedSet<int> scores = new SortedSet<int>{2, 5, 1, 3, 4, 6, 8, 7, 9, 10};
DisplayScores(scores);

scores.Add(0);
scores.Add(11);
DisplayScores(scores);

scores.Add(1);
DisplayScores(scores);