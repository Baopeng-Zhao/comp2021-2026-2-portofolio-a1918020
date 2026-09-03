using System.Collections.Generic;

var numbers = new LinkedList<int>();

numbers.AddFirst(10);
numbers.AddLast(114514);
numbers.AddBefore(numbers.Find(10), 9);
numbers.AddAfter(numbers.Find(10), 11);
for(int i = 0; i < 6; i++)
{
    numbers.AddLast(i);
}

Console.WriteLine("After Remove(): ");
numbers.Remove(8);
for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers.ElementAt(i));
}

Console.WriteLine("After RemoveFirst(): ");
numbers.RemoveFirst();
for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers.ElementAt(i));
}

Console.WriteLine("After RemoveLast(): ");
numbers.RemoveLast();
for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers.ElementAt(i));
}

Console.WriteLine("After delete 5th element:");
var node = numbers.First;
for (int i = 0; i < 3; i++)
{
    node = node.Next;
}
numbers.Remove(node);