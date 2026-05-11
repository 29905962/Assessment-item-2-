Task 1 workshop 9 BFS

public List<int> BreadthFirstSearch(int startVertex)
{
    ValidateVertex(startVertex);

    List<int> traversal = new List<int>();

    bool[] visited = new bool[VertexCount];

    Queue<int> queue = new Queue<int>();

    // Start with the starting vertex
    queue.Enqueue(startVertex);
    visited[startVertex] = true;

    while (queue.Count > 0)
    {
        int v = queue.Dequeue();

        traversal.Add(v);

        // Visit neighbours
        foreach (int n in GetNeighbors(v))
        {
            if (!visited[n])
            {
                visited[n] = true;
                queue.Enqueue(n);
            }
        }
    }

    return traversal;
}

Task 2 DepthFirstSearch

public List<int> DepthFirstSearch(int startVertex)
{
    ValidateVertex(startVertex);

    List<int> traversal = new List<int>();

    bool[] visited = new bool[VertexCount];

    Stack<int> stack = new Stack<int>();

    // Start with startVertex
    stack.Push(startVertex);
    visited[startVertex] = true;

    while (stack.Count > 0)
    {
        int v = stack.Pop();

        traversal.Add(v);

        IReadOnlyList<int> neighbours = GetNeighbors(v);

        // Reverse order
        for (int i = neighbours.Count - 1; i >= 0; i--)
        {
            int n = neighbours[i];

            if (!visited[n])
            {
                visited[n] = true;
                stack.Push(n);
            }
        }
    }

    return traversal;
}
