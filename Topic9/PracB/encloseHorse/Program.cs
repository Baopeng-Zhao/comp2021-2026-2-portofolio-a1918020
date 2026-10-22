using System.Runtime.CompilerServices;
using System.Security.Principal;

Graph graph = new Graph();
Node Start = new Node("Start");
Node A = new Node("A");
Node B = new Node("B (BEES)");
Node C = new Node("C");
Node D = new Node("D (BEES)");
Node E = new Node("E (BEES)");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I (BEES)");
Node J = new Node("J (BEES)");
Node K = new Node("K");
Node L = new Node("L");
Node M = new Node("M");
Node N = new Node("N");
Node End = new Node("End");

graph.AddEdge(Start, A, 1);
graph.AddEdge(Start, B, 5);
graph.AddEdge(Start, D, 5);

graph.AddEdge(A, C, 1);
graph.AddEdge(B, E, 5);

graph.AddEdge(D, C, 5);
graph.AddEdge(D, E, 5);
graph.AddEdge(D, G, 5);

graph.AddEdge(E, H, 5);
graph.AddEdge(C, F, 1);

graph.AddEdge(G, F, 1);
graph.AddEdge(G, H, 1);
graph.AddEdge(G, J, 1);

graph.AddEdge(F, I, 5);
graph.AddEdge(H, K, 1);

graph.AddEdge(J, I, 5);
graph.AddEdge(J, K, 5);
graph.AddEdge(J, M, 5);

graph.AddEdge(I, L, 5);
graph.AddEdge(K, N, 1);

graph.AddEdge(M, L, 1);
graph.AddEdge(M, N, 1);

graph.AddEdge(L, End, 1);

Node Target = End;
Dictionary<Node, int> DistanceList = new Dictionary<Node, int>();
DistanceList.Add(A, int.MaxValue);
DistanceList.Add(B, int.MaxValue);
DistanceList.Add(C, int.MaxValue);
DistanceList.Add(D, int.MaxValue);
DistanceList.Add(E, int.MaxValue);
DistanceList.Add(F, int.MaxValue);
DistanceList.Add(G, int.MaxValue);
DistanceList.Add(H, int.MaxValue);
DistanceList.Add(I, int.MaxValue);
DistanceList.Add(J, int.MaxValue);
DistanceList.Add(K, int.MaxValue);
DistanceList.Add(L, int.MaxValue);
DistanceList.Add(M, int.MaxValue);
DistanceList.Add(N, int.MaxValue);
DistanceList.Add(End, int.MaxValue);
DistanceList.Add(Start, 0);

PriorityQueue<Node, int> priorityQueue = new PriorityQueue<Node, int>();
Dictionary<Node, Node> parents = new Dictionary<Node, Node>();
parents[Start] = null;
priorityQueue.Enqueue(Start, 0);

while (priorityQueue.Count > 0)
{
    var current = priorityQueue.Dequeue();
    if(current == Target)
    {
        break;
    }
    foreach (Node edge in current.Edges.Keys)
    {
        int totalDistance = DistanceList[current] + current.Edges[edge];
        if (totalDistance >= DistanceList[edge])
        {
        }
        if(totalDistance < DistanceList[edge])
        {
            DistanceList[edge] = totalDistance;
            parents[edge] = current;
            priorityQueue.Enqueue(edge, totalDistance);
        }
    }
}

List<string> path = new List<string>();
Node node = Target;

while(node != null)
{
    path.Add(node.Data);
    node = parents[node];
}
path.Reverse();
foreach(string step in path)
{
    Console.WriteLine(step+"");
}