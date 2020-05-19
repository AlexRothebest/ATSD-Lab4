using System.Collections.Generic;


namespace Lab4
{
    class Connection
    {
        public Node Node;
        public int Weight;


        public Connection(Node Node, int Weight)
        {
            this.Node = Node;
            this.Weight = Weight;
        }
    }


    class Node
    {
        private static int MaxId = 0;

        public int Id;
        public List<Connection> Connections = new List<Connection>();


        public Node()
        {
            this.Id = MaxId + 1;
            MaxId++;
        }


        // public void Connect(Node NodeToConnect, int Weight)
        // {
        //     Edge NewEdge = new Edge(this, NodeToConnect, Weight);
        // }
    }
}