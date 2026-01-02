import heapq
class Solution:
    def networkDelayTime(self, times, n, k):
        # edge cases
        if n == 0:
            return -1
        if n == 1:
            return 0
        
        graph = {}
        for source, target, weight in times:
            if source not in graph:
                graph[source] = {}  # só consigo acessar 2 níveis se a chave do primeiro nível existir E o valor dela for um dicionário
            graph[source][target] = weight
        
        min_heap = [(0, k)]
        distances = {node: float('inf') for node in range(1, n+1)} # distances tem q ser pra todos nodes. Grafo é unidirecional então não da pra loopar graph
        distances[k] = 0

        while min_heap:
            curr_distance, curr_node = heapq.heappop(min_heap)
            if curr_distance > distances[curr_node]:
                continue
            if curr_node not in graph:
                continue

            for t, w in graph[curr_node].items():
                dist = curr_distance + w
                if dist < distances[t]:
                    distances[t] = dist
                    heapq.heappush(min_heap, (dist, t))
        
        _max = max(distances.values())
        return _max if _max != float('inf') else -1


