namespace DataStructureAndAlgorithms.DataStructures.BinaryTree;

public class LeetCode94
{
    // retornar os valores de uma binaryTree em inorder Traversal

    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        InorderTraversalRecursive(root, result);
        return result;
    }

    private void InorderTraversalRecursive(TreeNode node, List<int> result)
    {
        if (node == null)
            return;
        
        InorderTraversalRecursive(node.left, result);
        result.Add(node.val);
        InorderTraversalRecursive(node.right, result);
    }
    
    /* dentro do metodo crio uma lista que sera o output
     que armazenara os node.val e chamo a funcao recursiva
     para percorrer a binaryTree recursivamente comecando pelo root,
     dentro da chamada recursiva comeco por left, depois adiciono os valores
     e entao faco o right */
}