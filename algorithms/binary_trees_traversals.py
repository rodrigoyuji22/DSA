class TreeNode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
    
class BinaryTree:
    def __init__(self):
        self.root = None
    
    def insert(self, val):
        if not self.root:
            self.root = TreeNode(val)
        else:
            self._insert_recursive(self.root, val)
    
    def _insert_recursive(self, node, val):
        if val < node.val:
            if node.left:
                self._insert_recursive(node.left, val)
            else:
                node.left = TreeNode(val)
        else:
            if node.right:
                self._insert_recursive(node.right, val)
            else:
                node.right = TreeNode(val)
                
    def search(self, val):
        return self._search_recursive(self.root, val)
        
    def _search_recursive(self, node, val):
        if not node:
            return False
        if node.val == val:
            return True
        if val < node.val:
            self._search_recursive(node.left, val)
        self._search_recursive(node.right, val)
                
    def preorder_traversal(self):
        output = []
        self._preorder_recursive(self.root, output)
        return output
    
    def _preorder_recursive(self, node, arr):
        if node:
            arr.append(node.val)
            self._preorder_recursive(node.left, arr)
            self._preorder_recursive(node.right, arr)
            