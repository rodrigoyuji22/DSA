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
}

