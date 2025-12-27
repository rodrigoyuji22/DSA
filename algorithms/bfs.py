from collections import deque

# implementação com binary tree
class TreeNode:
    def __init__(self, val: int):
        self.val = val
        self.right = None
        self.left = None

class BinaryTree:
    def __init__(self):
        self.root = None
    
    def bfs_tree_node(self, target: int) -> bool:
        if self.root is None:
            return False
        queue = deque([self.root])
        
        while queue:
            curr = queue.popleft()
            if curr.val == target:
                return True
            if curr.right:
                queue.append(curr.right)
            if curr.left:
                queue.append(curr.left)
        return False 

# implementação com listas de adjacências
def bfs(data: dict[str, list[str]], start: str, target: str) -> bool:
    if start == target:
        return True
        
    visited = set()        
    queue = deque([start])
    visited.add(start)
    while queue:
        curr = queue.popleft()
        if curr == target:
            return True
        
        # iterar sobre data[curr] -> quero iterar sobre a lista value da chave curr
        for neighbor in data[curr]:
            if neighbor not in visited:
                queue.append(neighbor)
                visited.add(neighbor)
        
    return False
        

        
    