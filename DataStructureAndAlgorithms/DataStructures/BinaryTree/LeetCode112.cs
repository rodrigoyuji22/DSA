namespace DataStructureAndAlgorithms.DataStructures.BinaryTree;

public class LeetCode112
{
    /*
     Problema: verificar se existe um caminho que va do root ate leaf e que somados os nodos resulte em target.
     Solução: Depth-First-Search para percorrer de cima para baixo ate o nodo mais fundo de forma parecida
     com um Pre-Order Traversal (root>left>right) somando os valores do nodo e armazenando em uma variável e
     quando chegar no leaf, verificar se sum == target.
     
     */
    public bool HasPathSum(TreeNode root, int targetSum) {
        return DfsRecursive(root, 0, targetSum);
    }

    private bool DfsRecursive(TreeNode node, int sum, int targetSum)
    {
        if(node == null)
            return false;
        sum+=node.val;
        
        if(node.left == null && node.right == null)
           if(sum == targetSum)
               return true;
        if (DfsRecursive(node.left, sum, targetSum))
            return true;
        if(DfsRecursive(node.right, sum, targetSum))
            return true;
           
        return false;
    }
}