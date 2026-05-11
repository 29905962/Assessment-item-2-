namespace Workshop7;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree<T>
{
    public Node<T>? Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    /// <summary>
    /// Build the workshop tree structure.
    /// </summary>
    public static BinaryTree<int> BuildWorkshopTree()
    {
        BinaryTree<int> tree = new BinaryTree<int>();

        // Create nodes
        Node<int> node8 = new Node<int>(8);
        Node<int> node4 = new Node<int>(4);
        Node<int> node12 = new Node<int>(12);
        Node<int> node2 = new Node<int>(2);
        Node<int> node6 = new Node<int>(6);
        Node<int> node10 = new Node<int>(10);
        Node<int> node14 = new Node<int>(14);
        Node<int> node1 = new Node<int>(1);

        // Connect nodes
        node8.Left = node4;
        node8.Right = node12;

        node4.Left = node2;
        node4.Right = node6;

        node12.Left = node10;
        node12.Right = node14;

        node2.Left = node1;

        // Set root
        tree.Root = node8;

        return tree;
    }

    /// <summary>
    /// Calculate the height of the tree.
    /// </summary>
    public int Height()
    {
        return HeightHelper(Root);
    }

    private int HeightHelper(Node<T>? node)
    {
        // Empty tree/subtree
        if (node == null)
        {
            return -1;
        }

        // Recursively calculate heights
        int leftHeight = HeightHelper(node.Left);
        int rightHeight = HeightHelper(node.Right);

        // Return larger height + 1 edge
        return Math.Max(leftHeight, rightHeight) + 1;
    }

    /// <summary>
    /// Level order traversal (BFS).
    /// </summary>
    public List<T> LevelOrderTraversal()
    {
        List<T> result = new List<T>();

        if (Root == null)
        {
            return result;
        }

        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node<T> current = queue.Dequeue();
            result.Add(current.Value);

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        return result;
    }

    /// <summary>
    /// Depth-first traversal (pre-order).
    /// </summary>
    public List<T> DepthFirstTraversal()
    {
        List<T> result = new List<T>();
        DepthFirstTraversalHelper(Root, result);
        return result;
    }

    private void DepthFirstTraversalHelper(Node<T>? node, List<T> result)
    {
        if (node == null)
        {
            return;
        }

        // Visit current node
        result.Add(node.Value);

        // Traverse left subtree
        DepthFirstTraversalHelper(node.Left, result);

        // Traverse right subtree
        DepthFirstTraversalHelper(node.Right, result);
    }
}
