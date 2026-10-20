Graph graph = new Graph();
Node A = new Node("A");
Node B = new Node("B");
Node C = new Node("C");
Node D = new Node("D");
Node E = new Node("E");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I");
graph.AddEdge(A,B);
graph.AddEdge(B,C);
graph.AddEdge(C,D);
graph.AddEdge(D,E);
graph.AddEdge(E,F);
graph.AddEdge(F,G);
graph.AddEdge(G,H);
graph.AddEdge(H,I);
Console.WriteLine("Here is Graph.Tostring");
Console.WriteLine(graph.ToString());

List<Node> CheckedNodes1 = new List<Node>();
Queue<Node> visitLine1 = new Queue<Node>();
Node Target1 = I;
bool found1 = false;

visitLine1.Enqueue(A);
while (visitLine1.Count > 0)
{
    Node current = visitLine1.Dequeue();
    if(current == Target1)
    {
        found1 = true;
        break;
    }
    CheckedNodes1.Add(current);
    foreach (Node edge in current.Edges)
    {
        if (!CheckedNodes1.Contains(edge))
        {
            visitLine1.Enqueue(edge);
        }
    }
}
foreach(Node node in CheckedNodes1)
{
    Console.WriteLine(node.Data);
}
Console.WriteLine("Found:" + found1);

Console.WriteLine("");
graph.AddEdge(A,H);
graph.AddEdge(H,I);
List<Node> CheckedNodes2 = new List<Node>();
Stack<Node> visitLine2 = new Stack<Node>();
Node Target2 = I;
bool found2 = false;

visitLine2.Push(A);
while (visitLine2.Count > 0)
{
    Node current = visitLine2.Pop();
    if(current == Target2)
    {
        found2 = true;
        break;
    }
    CheckedNodes2.Add(current);
    foreach (Node edge in current.Edges)
    {
        if (!CheckedNodes2.Contains(edge))
        {
            visitLine2.Push(edge);
        }
    }
}
foreach(Node node in CheckedNodes2)
{
    Console.WriteLine(node.Data);
}
Console.WriteLine("Found:" + found2);