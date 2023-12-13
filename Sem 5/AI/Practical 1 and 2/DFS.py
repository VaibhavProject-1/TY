from collections import deque

def iterativeDFS(graph, start, destination):
    stack = deque()
    visited = []
    stack.appendleft(start)

    while stack:
        node = stack.popleft()

        if node in visited:
            continue

        visited.append(node)
        print(node)

        if node == destination:
            return

        for neighbor in graph[node]:
            if neighbor not in visited:
                stack.appendleft(neighbor)




if __name__ == "__main__":

    Graph = {
    "Charni Road": ["Marine Drive", "Haji Ali"],
    "Marine Drive": ["Charni Road", "Nariman Point"],
    "Nariman Point": ["Marine Drive", "CST"],
    "CST": ["Nariman Point", "Parel"],
    "Parel": ["CST", "Kurla"],
    "Kurla": ["Parel", "BKC"],
    "BKC": ["Kurla", "Lower Parel"],
    "Haji Ali": ["Charni Road", "Mahalaxmi"],
    "Mahalaxmi": ["Haji Ali", "Worli"],
    "Worli": ["Mahalaxmi", "Lower Parel"],
    "Lower Parel": ["Worli", "BKC"],
    "BKC": []
  }

    start = "Charni Road"
    destination = "BKC"

    iterativeDFS(Graph, start, destination)
