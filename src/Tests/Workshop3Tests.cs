using Xunit;
using Workshop3;

namespace Workshops.Tests;

public class Workshop3Tests
{
    [Fact]
    public void TestBinarySearchIterative_TargetFound()
    {
        int[] array = [100, 80, 60, 40, 20];
        var result = BinarySearch.BinarySearchDescendingIterativeWithSteps(array, 40);
        
        Assert.Equal(3, result.Index);
        Assert.Equal(2, result.Steps);
    }

    [Fact]
    public void TestBinarySearchIterative_TargetNotFound()
    {
        int[] array = [100, 80, 60, 40, 20];
        var result = BinarySearch.BinarySearchDescendingIterativeWithSteps(array, 50);
        
        Assert.Equal(-1, result.Index);
    }

    [Fact]
    public void TestBinarySearchRecursive_TargetFound()
    {
        int[] array = [100, 80, 60, 40, 20];
        var result = BinarySearch.BinarySearchDescendingRecursiveWithSteps(array, 40, 0, array.Length - 1, 0);
        
        Assert.Equal(3, result.Index);
        Assert.Equal(2, result.Steps);
    }

    [Fact]
    public void TestBinarySearchRecursive_TargetNotFound()
    {
        int[] array = [100, 80, 60, 40, 20];
        var result = BinarySearch.BinarySearchDescendingRecursiveWithSteps(array, 50, 0, array.Length - 1, 0);
        
        Assert.Equal(-1, result.Index);
    }

    [Fact]
    public void TestIterativeVsRecursive_SameResults()
    {
        int[] array = [100, 80, 60, 40, 20];
        int target = 60;

        var iterResult = BinarySearch.BinarySearchDescendingIterativeWithSteps(array, target);
        var recResult = BinarySearch.BinarySearchDescendingRecursiveWithSteps(array, target, 0, array.Length - 1, 0);

        Assert.Equal(iterResult.Index, recResult.Index);
        Assert.Equal(iterResult.Steps, recResult.Steps);
    }
}
