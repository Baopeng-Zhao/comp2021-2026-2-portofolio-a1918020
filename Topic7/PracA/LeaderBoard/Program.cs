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

SortedSet<BankAccount> BankAccounts = new SortedSet<BankAccount>(new BankComparer()){ian, jack, alice, tom, jerry, yufei, rusell, sue, aroosh, sam};

void DisplayAccounts(SortedSet<BankAccount> BankAccounts){
    foreach(BankAccount account in BankAccounts)
    {
        Console.WriteLine($"Name is: {account.Owner} and the Balance is: {account.Balance}");
    }
}

DisplayAccounts(BankAccounts);
Console.WriteLine("");

BankAccount Liam = new BankAccount("Liam", 100m);
BankAccount Olivia = new BankAccount("Olivia", 10201m);
BankAccount Ethan = new BankAccount("Ethan", 10032m);
BankAccount Sophia = new BankAccount("Sophia", 3m);
BankAccount Noah = new BankAccount("Noah", 144m);
BankAccount Mia = new BankAccount("Mia", 1025m);
BankAccount Lucas = new BankAccount("Lucas", 1506m);
BankAccount Chloe = new BankAccount("Chloe", 1507m);
BankAccount Daniel = new BankAccount("Daniel", 18m);
BankAccount Grace = new BankAccount("Grace", 1m);
BankAccounts.Add(Liam);
BankAccounts.Add(Olivia);
BankAccounts.Add(Ethan);
BankAccounts.Add(Sophia);
BankAccounts.Add(Noah);
BankAccounts.Add(Mia);
BankAccounts.Add(Lucas);
BankAccounts.Add(Chloe);
BankAccounts.Add(Daniel);
BankAccounts.Add(Grace);

DisplayAccounts(BankAccounts);
Console.WriteLine("");

BankAccount poor = new BankAccount("poor", 0m);
BankAccount rich = new BankAccount("rich", 10000m);
BankAccounts.Add(poor);
BankAccounts.Add(rich);

DisplayAccounts(BankAccounts);
Console.WriteLine("");

BankAccounts.Add(ian);
DisplayAccounts(BankAccounts);
Console.WriteLine("");

double[] dataY = new double[BankAccounts.Count];
int i = 0;
foreach (BankAccount account in BankAccounts)
{
    dataY[i] = (double)account.Balance;
    i++;
}
ScottPlot.Plot myPlot = new();
myPlot.YLabel("Account Balance", size: 20);
myPlot.XLabel("Ranking", size:20);
myPlot.Axes.Margins(bottom:0, top:0.2);
myPlot.Add.Bars(dataY);myPlot.SavePng("Topic7A-Task3.png", 800, 600);
