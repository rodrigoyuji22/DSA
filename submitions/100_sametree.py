from collections import deque
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution:
    def isSameTree(self, p: TreeNode, q: TreeNode) -> bool:
        p_list = self.bfs(p)
        q_list = self.bfs(q)

        if p_list == q_list:
            return True
        else:
            return False

    def bfs(self, root: TreeNode):
        if root is None:
            return []
        queue = deque()
        queue.append(root)
        output = []
        while queue:
            curr = queue.popleft()
            if curr is None: 
                output.append(None)
            else:
                queue.append(curr.left)
                queue.append(curr.right)
                output.append(curr.val)

        return output

