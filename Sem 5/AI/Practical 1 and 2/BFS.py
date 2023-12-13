def bfs_traverse(visited, graph, start):
    visited.append(start)
    queue.append(start)

    while queue:
        m = queue.pop(0)
        print(m)

        for neighbour in graph[m]:
            if neighbour not in visited:
                visited.append(neighbour)
                queue.append(neighbour)




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
    "Lower Parel": ["Worli", "BKC"]
  }

    visited = []
    queue = []
    start = "Charni Road"

    bfs_traverse(visited, Graph, start)
