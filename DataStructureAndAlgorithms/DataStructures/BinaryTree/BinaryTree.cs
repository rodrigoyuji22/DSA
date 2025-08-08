namespace DataStructureAndAlgorithms.DataStructures.BinaryTree;
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val)
    {
        this.val = val;
        left = null;
        right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int val)
    {
        if (Root == null)
        {
            Root = new TreeNode(val);
        }
        else
        {
            InsertRecursive(Root, val);
        }
    }
    private void InsertRecursive(TreeNode node, int val)
    {
        if (val < node.val)
        {
            if(node.left == null)
                node.left = new TreeNode(val);
            else
                InsertRecursive(node.left, val);
        }
        else
        {
            if (node.right == null)
                node.right = new TreeNode(val);
            else
                InsertRecursive(node.right, val);
        }
    }

    public bool Search(int val)
    {
        return SearchRecursive(Root, val);
    }

    private bool SearchRecursive(TreeNode node, int val)
    {
        if (node == null)
            return false;
        if(node.val == val)
            return true;
        if(val < node.val)
            return SearchRecursive(node.left, val);
        return SearchRecursive(node.right, val);
    }
    
    public bool Dfs(int val)
    {
        return DfsRecursive(Root, val);
    }

    private bool DfsRecursive(TreeNode node, int val)
    {
        if (node == null)
            return false;
        if(node.val == val)
            return true;
        
        if(SearchRecursive(node.left, val))
            return true;
        if(SearchRecursive(node.right, val))
            return true;
        
        return false;
    }    
    
    public IList<int> PreOrderTraversal()
    {
        var result = new List<int>();
        PreOrderTraversalRecursive(Root, result);
        return result;
    }

    private void PreOrderTraversalRecursive(TreeNode node, IList<int> result)
    {
        if(node == null)
            return;
        result.Add(node.val);
        PreOrderTraversalRecursive(node.left, result);
        PreOrderTraversalRecursive(node.right, result);
        // executa a primeira chamada recursiva ate cair no caso base, interrompe a execucao e comeca a execucao da segunda chamada
    }
    public IList<int> InOrderTraversal()
    {
        var result = new List<int>();
        InOrderTraversalRecursive(Root, result);
        return result;
    }
    private void InOrderTraversalRecursive(TreeNode node, IList<int> result)
    {
        if(node == null)
            return;
        InOrderTraversalRecursive(node.left, result);
        result.Add(node.val);
        InOrderTraversalRecursive(node.right, result);
    }
    public IList<int> PostOrderTraversal()
    {
        var result = new List<int>();
        PostOrderTraversalRecursive(Root, result);
        return result;
    }
    private void PostOrderTraversalRecursive(TreeNode node, IList<int> result)
    {
        if(node == null)
            return;
        PostOrderTraversalRecursive(node.left, result);
        PostOrderTraversalRecursive(node.right, result);
        result.Add(node.val);
        
    }

    public bool Bfs(TreeNode root, int target)
    {
        if (root == null)
            return false;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // iteracao da fila, enquanto ela nao for vazia(quantidade de elementos maior que 0)
        while (queue.Count > 0)
        {
            /* dequeue serve tanto para ler o elemento que estou removendo da fila quanto para referenciar.
             Na implementacao estou utilizando o dequeue para comparar com target e para referenciar os nodos
             filhos, adicionando os a fila.*/
            var node = queue.Dequeue();
            if (node.val == target)
                return true;
            if(node.left != null)
                queue.Enqueue(node.left);
            if(node.right != null)
                queue.Enqueue(node.right);
        }
        return false;
    }
    
    
}

