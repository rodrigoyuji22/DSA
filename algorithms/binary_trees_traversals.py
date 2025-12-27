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
                
    def search(self, target):
        return self._search_recursive(self.root, target)
        
    def _search_recursive(self, node, target):
        if not node:
            return False
        if node.val == target:
            return True
        if target < node.val:
            return self._search_recursive(node.left, target)
        return self._search_recursive(node.right, target)
                
    def preorder_traversal(self):
        output = []
        self._preorder_recursive(self.root, output)
        return output
    
    def _preorder_recursive(self, node, arr):
        if node:
            arr.append(node.val)
            self._preorder_recursive(node.left, arr)
            self._preorder_recursive(node.right, arr)

    def inoorder_traversal(self):
        output = []
        self._inorder_recursive(self.root, output)
        return output
    
    def _inorder_recursive(self, node, arr):
        if node:
            arr.append(node.val)
            self._inorder_recursive(node.left, arr)
            self._inorder_recursive(node.right, arr)
            
    def postorder_traversal(self):
        output = []
        self._postorder_recursive(self.root, output)
        return output
    
    def _postorder_recursive(self, node, arr):
        if node:
            arr.append(node.val)
            self._postorder_recursive(node.left, arr)
            self._postorder_recursive(node.right, arr)
            