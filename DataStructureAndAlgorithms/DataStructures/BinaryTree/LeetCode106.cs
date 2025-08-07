namespace DataStructureAndAlgorithms.DataStructures.BinaryTree;

public class LeetCode106
{
    /* Construir uma binaryTree com base no inorderTraversal e postorderTraversal que é dado
    inorder = [9,3,15,20,7]   postorder = [9,15,7,20,3]
    obs: O root é o último elemento de um postorder, ja que é left > right > root, e no inorder, tudo que está
    à esquerda de root é left e tudo que está à direita é right
    */
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        var inorderList = inorder.ToList();
        var postorderList = postorder.ToList();
        
        return BuildTreeRecursive(inorderList, postorderList);
    }

    private TreeNode BuildTreeRecursive(List<int> inorder, List<int> postorder)
    {
        if(inorder.Count == 0 || postorder.Count == 0) 
            return null;

        var root = new TreeNode(postorder[postorder.Count - 1]);
        postorder.RemoveAt(postorder.Count - 1);
        var rootIdx = inorder.IndexOf(root.val);
        var inorderRight = inorder.GetRange(rootIdx + 1, inorder.Count - rootIdx - 1);
        var inorderLeft = inorder.GetRange(0, rootIdx);
        
        root.right = BuildTreeRecursive(inorderRight, postorder);
        root.left = BuildTreeRecursive(inorderLeft, postorder);
        
        return root;
    }
}