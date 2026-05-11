namespace Workshop9;

public class Graph
{
    private List<int>[] _adjacencyList;
    public int VertexCount { get; }

    public Graph(int vertexCount)
    {
        VertexCount = vertexCount;
        _adjacencyList = new List<int>[vertexCount];
        for (int i = 0; i < vertexCount; i++)
        {
            _adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        ValidateVertex(u);
        ValidateVertex(v);
        _adjacencyList[u].Add(v);
        _adjacencyList[v].Add(u);
    }

    public IReadOnlyList<int> GetNeighbors(int vertex)
    {
        ValidateVertex(vertex);
        return _adjacencyList[vertex].AsReadOnly();
    }

    protected void ValidateVertex(int vertex)
    {
        if (vertex < 0 || vertex >= VertexCount)
        {
            throw new ArgumentOutOfRangeException(nameof(vertex), "Vertex out of range");
        }
    }

    /// <summary>
    /// Breadth-First Search starting from a given vertex.
    /// </summary>
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

    /// <summary>
    /// Depth-First Search starting from a given vertex.
    /// </summary>
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
}
