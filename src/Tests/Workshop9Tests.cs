using Xunit;
using Workshop9;

namespace Workshops.Tests;

public class Workshop9Tests
{
    private Graph CreateTestGraph()
    {
        // Create a simple graph:
        // 0 -- 1 -- 2
        // |         |
        // 3 -- 4 -- 5
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(2, 5);
        return graph;
    }

    [Fact]
    public void TestBreadthFirstSearch()
    {
        var graph = CreateTestGraph();
        var result = graph.BreadthFirstSearch(0);
        
        Assert.Equal(6, result.Count);
        Assert.Equal(0, result[0]);
    }

    [Fact]
    public void TestDepthFirstSearch()
    {
        var graph = CreateTestGraph();
        var result = graph.DepthFirstSearch(0);
        
        Assert.Equal(6, result.Count);
        Assert.Equal(0, result[0]);
    }

    [Fact]
    public void TestGraphWithSingleVertex()
    {
        Graph graph = new Graph(1);
        var bfs = graph.BreadthFirstSearch(0);
        var dfs = graph.DepthFirstSearch(0);
        
        Assert.Single(bfs);
        Assert.Single(dfs);
        Assert.Equal(0, bfs[0]);
        Assert.Equal(0, dfs[0]);
    }
}
