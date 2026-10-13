using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

Hashtable scoreHash = new Hashtable();

Player player1 = new Player("ian", 100, 10, 5);
Player player2 = new Player("Alice", 100, 10, 5);
Player player3 = new Player("Jack", 100, 10, 5);
Player player4 = new Player("Rusell", 100, 10, 5);
Player player5 = new Player("Bob", 100, 10, 5);
string unexpected = "";

scoreHash.Add(player1, 1000);
scoreHash.Add(player2, 1001);
scoreHash.Add(player3, 1005);
scoreHash.Add(player4, 1003);
scoreHash.Add(player5, 1004);

var sorted = scoreHash.Cast<DictionaryEntry>().OrderByDescending(x => (int)x.Value);

foreach(DictionaryEntry entity in sorted)
{
    Console.WriteLine($"The Player: {entity.Key} : {entity.Value}");
}

scoreHash.Add(unexpected, 0);

scoreHash.Add(player5, 1004);