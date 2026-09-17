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

PriorityQueue<Player, int> EventQueue = new PriorityQueue<Player, int>();
EventQueue.Enqueue(player1, 1);
EventQueue.Enqueue(player2, 2);
EventQueue.Enqueue(player3, 3);
EventQueue.Enqueue(player4, 4);
EventQueue.Enqueue(player5, 5);
EventQueue.Enqueue(player6, 6);
EventQueue.Enqueue(player7, 7);
EventQueue.Enqueue(player8, 8);
EventQueue.Enqueue(player9, 9);
EventQueue.Enqueue(player10, 10);

while(EventQueue.Count != 0)
{
    Console.WriteLine(EventQueue.Dequeue());
}

Player player11 = new Player("noname", 100, 10, 5);
EventQueue.Enqueue(player11, 11);