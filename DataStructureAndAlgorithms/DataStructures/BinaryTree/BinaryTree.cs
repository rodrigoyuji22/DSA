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
    
    public IList<TreeNode> PreOrderTraversal()
    {
        var result = new List<TreeNode>();
        PreOrderTraversalRecursive(Root, result);
        return result;
    }

    private void PreOrderTraversalRecursive(TreeNode node, IList<TreeNode> result)
    {
        if(node == null)
            return;
        result.Add(node);
        PreOrderTraversalRecursive(node.left, result);
        PreOrderTraversalRecursive(node.right, result);
        // executa a primeira chamada recursiva ate cair no caso base, interrompe a execucao e comeca a execucao da segunda chamada
    }
    public IList<TreeNode> InOrderTraversal()
    {
        var result = new List<TreeNode>();
        InOrderTraversalRecursive(Root, result);
        return result;
    }
    private void InOrderTraversalRecursive(TreeNode node, IList<TreeNode> result)
    {
        if(node == null)
            return;
        InOrderTraversalRecursive(node.left, result);
        result.Add(node);
        InOrderTraversalRecursive(node.right, result);
    }
    public IList<TreeNode> PostOrderTraversal()
    {
        var result = new List<TreeNode>();
        PostOrderTraversalRecursive(Root, result);
        return result;
    }
    private void PostOrderTraversalRecursive(TreeNode node, IList<TreeNode> result)
    {
        if(node == null)
            return;
        PostOrderTraversalRecursive(node.left, result);
        PostOrderTraversalRecursive(node.right, result);
        result.Add(node);
        
    }
    
    
}

