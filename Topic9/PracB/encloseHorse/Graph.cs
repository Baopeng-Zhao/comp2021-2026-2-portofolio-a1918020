public class Graph
{
    public List<Node> Nodes {get; set;}
    public void AddEdge(Node fromNode, Node toNode, int weight)
    {
        Nodes.Add(fromNode);
        Nodes.Add(toNode);
        fromNode.Edges.Add(toNode, weight);
        toNode.Edges.Add(fromNode, weight);
    }

    public Graph()
    {
        Nodes = new List<Node>();
    }

    public override string ToString()
    {
        string result = "";
        foreach(Node node in Nodes)
        {
            result += node.Data + "\n";
        }
        return result;
    }
    
}