namespace DataStructureAndAlgorithms.DataStructures.Graph;

public class LeetCode133
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        // IList<Node>? = a lista pode ser vazia, IList<Node?> = os nodos da lista podem ser vazios
        public Node(int val = 0, IList<Node>? neighbors = null)
        {
            this.val = val;
            this.neighbors = neighbors ?? new List<Node>();
            // if(neighbors != null)
            //     this.neighbors = neighbors;
            // else
            //     this.neighbors = new List<Node>();
            /* se neighbors nao for null, utilize o valor instanciado, caso contrario
               utilize uma new List<Node>(); */
        }
        public Node CloneGraph(Node node) {
            var map = new Dictionary<Node, Node>();
            if(node == null)
                return node;
            var q = new Queue<Node>();
            q.Enqueue(node);
            map[node] = new Node(node.val);
            while(q.Count > 0)
            {
                var curr = q.Dequeue();
                foreach(var neighbor in curr.neighbors)
                {
                    if(!map.ContainsKey(neighbor))
                    {   
                        q.Enqueue(neighbor);
                        map[neighbor] = new Node(neighbor.val);
                    }
                    // fora do if pois o grafo não é direcionado
                    map[curr].neighbors.Add(map[neighbor]);
                }


            }
            return map[node];

        }
        
    }
}