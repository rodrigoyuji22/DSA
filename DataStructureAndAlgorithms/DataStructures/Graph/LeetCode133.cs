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
    }
}