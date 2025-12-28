from collections import deque

class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []


class Solution:
    def cloneGraph(self, node):
        if not node:
            return None
        q = deque([node])
        clones = {}
        clones[node.val] = Node(node.val, [])

        while q:
            curr = q.popleft()
            curr_clone = clones[curr.val]

            for neighbor in curr.neighbors:
                if neighbor.val not in clones:
                    clones[neighbor.val] = Node(neighbor.val, [])
                    q.append(neighbor)
                curr_clone.neighbors.append(clones[neighbor.val])
        return clones[node.val]