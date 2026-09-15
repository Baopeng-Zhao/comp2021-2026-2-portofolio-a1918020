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

BankAccount ian = new BankAccount("ian", 1000m);
BankAccount jack = new BankAccount("jack", 1001m);
BankAccount alice = new BankAccount("alice", 1002m);
BankAccount tom = new BankAccount("tom", 1003m);
BankAccount jerry = new BankAccount("jerry", 1004m);
BankAccount yufei = new BankAccount("yufei", 1005m);
BankAccount rusell = new BankAccount("rusell", 1006m);
BankAccount sue = new BankAccount("sue", 1007m);
BankAccount aroosh = new BankAccount("aroosh", 1008m);
BankAccount sam = new BankAccount("sam", 1009m);

SortedSet<BankAccount> BankAccounts = new SortedSet<BankAccount>{ian, jack, alice, tom, jerry, yufei, rusell, sue, aroosh, sam};
