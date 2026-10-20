public class Graph
{
    public List<Node> Nodes {get; set;}
    public void AddEdge(Node fromNode, Node toNode)
    {
        Nodes.Add(fromNode);
        Nodes.Add(toNode);
        fromNode.Edges.Add(toNode);
        toNode.Edges.Add(fromNode);
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