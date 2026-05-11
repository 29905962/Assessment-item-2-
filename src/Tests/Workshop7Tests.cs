using Xunit;
using Workshop7;

namespace Workshops.Tests;

public class Workshop7Tests
{
    [Fact]
    public void TestBuildWorkshopTree()
    {
        var tree = BinaryTree<int>.BuildWorkshopTree();
        Assert.NotNull(tree.Root);
        Assert.Equal(8, tree.Root.Value);
    }

    [Fact]
    public void TestHeight()
    {
        var tree = BinaryTree<int>.BuildWorkshopTree();
        int height = tree.Height();
        Assert.Equal(3, height); // Height is 3 (0-indexed: root=0, level1=1, level2=2, level3=3)
    }

    [Fact]
    public void TestLevelOrderTraversal()
    {
        var tree = BinaryTree<int>.BuildWorkshopTree();
        var result = tree.LevelOrderTraversal();
        
        int[] expected = [8, 4, 12, 2, 6, 10, 14, 1];
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestDepthFirstTraversal()
    {
        var tree = BinaryTree<int>.BuildWorkshopTree();
        var result = tree.DepthFirstTraversal();
        
        int[] expected = [8, 4, 2, 1, 6, 12, 10, 14];
        Assert.Equal(expected, result);
    }
}
