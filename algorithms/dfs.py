class TreeNode:
    def __init__(self, val: int):
        self.val = val
        self.right = None
        self.left = None
        
class BinaryTree:
    def __init__(self):
        self.root = None

    def dfs(self, target):
        return self._dfs_recursive(self.root, target)
        
    def _dfs_recursive(self, node, target):
        if not node:
            return False
        if node.val == target:
            return True
            
        if self._dfs_recursive(node.left, target):
            return True
        return self._dfs_recursive(node.right, target)