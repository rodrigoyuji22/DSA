namespace DataStructureAndAlgorithms.DataStructures.BinaryTree;

public class LeetCode102
{
    /* problema envolvendo bfs(Breadth-First-Search) para retornar em forma de IList o valor dos elementos de cada level
     dentro de lists. ex: [[3], [9,20], [15,7]]*/
    public IList<IList<int>> LevelOrder(TreeNode root) {
        //edgecase, se a binaryTree nao existir, retornar uma lista vazia
        if(root == null)
            return new List<IList<int>>();

        // edgecase, preciso retornar uma lista de uma interface que implemente IList<int>
        var res = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        // caso "base"
        queue.Enqueue(root);

        // a fila expande a cada iteracao pois adiciona a fila os filhos do node atual
        while(queue.Count > 0)
        {
            var levelSize = queue.Count;
            var currentLevel = new List<int>();

            for(int i =0; i<levelSize; i++)
            {
                var node = queue.Dequeue();            
                if(node.left != null)
                    queue.Enqueue(node.left);
                if(node.right != null)
                    queue.Enqueue(node.right);

                currentLevel.Add(node.val);
            }
            res.Add(currentLevel);
        }
        return res;
    }
}