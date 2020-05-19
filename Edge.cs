namespace Lab4
{
    class Edge
    {
        public Node[] Nodes = new Node[2];
        public int Weight;
        // public string Id;


        public Edge(Node Node1, Node Node2, int Weight)
        {
            this.Nodes[0] = Node1;
            this.Nodes[1] = Node2;
            this.Weight = Weight;
            
            Node1.Connections.Add(new Connection(Node2, Weight));
            Node2.Connections.Add(new Connection(Node1, Weight));
        }
    }
}