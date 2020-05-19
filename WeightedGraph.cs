using System.Linq;
using System.Collections.Generic;


namespace Lab4
{
    class WeightedGraph
    {
        public List<Node> Nodes = new List<Node>();
        public List<Edge> Edges = new List<Edge>();


        public Dictionary<Node, int> Dijkstra(Node StartNode)
        {
            Dictionary<Node, int> Distances = new Dictionary<Node, int>();
            List<Node> OtherNodes = this.Nodes.FindAll(Node => Node != StartNode);
            OtherNodes.ForEach(Node => Distances.Add(Node, -1));

            Node CurrentNode = StartNode;
            for (int i = OtherNodes.Count(); i > 0; i--)
            {
                CurrentNode.Connections.ForEach(Connection => {
                    
                });
            }
        }
    }
}