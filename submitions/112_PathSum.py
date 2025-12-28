class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
        
class Solution:
    def hasPathSum(self, root, targetSum):
        if not root:
            return False
        return self.target_recursive(root, 0, targetSum)
    def target_recursive(self, node, _sum, target):
        if not node:
            return False

        _sum += node.val
        if node.left is None and node.right is None:
            if _sum == target:
                return True
        
        return self.target_recursive(node.left, _sum, target) or self.target_recursive(node.right, _sum, target)

# Não consigo manter o valor de uma variavel dentro da função recursiva, ela só se mantem se for argumento da função recursiva




        