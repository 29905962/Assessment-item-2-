# Assessment Item 2 - Workshop Solutions

This repository contains solutions for the C# algorithm workshops.

## Project Structure

```
├── Assessment.slnx              # Solution file
└── src/
    ├── Workshops.csproj         # Main project file
    ├── Workshop3/
    │   └── BinarySearch.cs      # Binary search implementations
    ├── Workshop4/
    │   ├── SelectionSort.cs     # Selection sort
    │   └── InsertionSort.cs     # Insertion sort
    ├── Workshop7/
    │   └── BinaryTree.cs        # Binary tree operations
    ├── Workshop9/
    │   └── Graph.cs             # Graph traversals (BFS/DFS)
    └── Tests/
        ├── Workshop3Tests.cs
        ├── Workshop4Tests.cs
        ├── Workshop7Tests.cs
        └── Workshop9Tests.cs
```

## Workshop Implementations

### Workshop 3: Binary Search
- Iterative binary search on descending arrays
- Recursive binary search with step counting
- Comparison of both approaches

### Workshop 4: Sorting Algorithms
- Selection Sort (ascending, in-place)
- Insertion Sort (ascending, in-place)
- Comparison and swap counting

### Workshop 7: Binary Trees
- Tree construction
- Height calculation
- Level-order traversal (BFS)
- Depth-first traversal (pre-order DFS)

### Workshop 9: Graph Traversals
- Breadth-First Search (BFS)
- Depth-First Search (DFS)
- Graph representation using adjacency lists

## Running Tests

```bash
dotnet test
```

## Building

```bash
dotnet build Assessment.slnx
```
