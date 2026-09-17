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

Console.WriteLine("After adding: ");
Console.WriteLine("");

Player player11 = new Player("noname", 100, 10, 5);
EventQueue.Enqueue(player11, 11);

while(EventQueue.Count != 0)
{
    Console.WriteLine(EventQueue.Dequeue());
}

Console.WriteLine("");
Console.WriteLine("");

var EventQueue2 = new PriorityQueue<Player, Priority>();
Priority priorityPlayer1 = Priority.HighPriority;
Priority priorityPlayer2 = Priority.MediumPriority;
Priority priorityPlayer3 = Priority.LowPriority;
Priority priorityPlayer4 = Priority.LowPriority;
Priority priorityPlayer5 = Priority.MediumPriority;
Priority priorityPlayer6 = Priority.LowPriority;
Priority priorityPlayer7 = Priority.HighPriority;
Priority priorityPlayer8 = Priority.HighPriority;
Priority priorityPlayer9 = Priority.MediumPriority;
Priority priorityPlayer10 = Priority.MediumPriority;

EventQueue2.Enqueue(player1, priorityPlayer1);
EventQueue2.Enqueue(player2, priorityPlayer2);
EventQueue2.Enqueue(player3, priorityPlayer3);
EventQueue2.Enqueue(player4, priorityPlayer4);
EventQueue2.Enqueue(player5, priorityPlayer5);
EventQueue2.Enqueue(player6, priorityPlayer6);
EventQueue2.Enqueue(player7, priorityPlayer7);
EventQueue2.Enqueue(player8, priorityPlayer8);
EventQueue2.Enqueue(player9, priorityPlayer9);
EventQueue2.Enqueue(player10, priorityPlayer10);

while(EventQueue2.Count != 0)
{
    Console.WriteLine(EventQueue2.Dequeue());
}

Console.WriteLine("After adding: ");
Console.WriteLine("");

Priority priorityPlayer11 =Priority.HighPriority;
EventQueue2.Enqueue(player11, priorityPlayer11);

while(EventQueue2.Count != 0)
{
    Console.WriteLine(EventQueue2.Dequeue());
}
