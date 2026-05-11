using Xunit;
using Workshop4;

namespace Workshops.Tests;

public class Workshop4Tests
{
    [Fact]
    public void TestSelectionSort_Ascending()
    {
        int[] data = [64, 34, 25, 12, 22, 11, 90];
        var (comps, swaps) = SelectionSort.Sort(data);

        int[] expected = [11, 12, 22, 25, 34, 64, 90];
        Assert.Equal(expected, data);
        Assert.True(comps > 0);
        Assert.True(swaps > 0);
    }

    [Fact]
    public void TestSelectionSort_AlreadySorted()
    {
        int[] data = [1, 2, 3, 4, 5];
        var (comps, swaps) = SelectionSort.Sort(data);

        int[] expected = [1, 2, 3, 4, 5];
        Assert.Equal(expected, data);
        Assert.Equal(10, comps); // n*(n-1)/2 = 5*4/2 = 10
        Assert.Equal(0, swaps);  // No swaps needed
    }

    [Fact]
    public void TestInsertionSort_Ascending()
    {
        int[] data = [64, 34, 25, 12, 22, 11, 90];
        var (comps, swaps) = InsertionSort.Sort(data);

        int[] expected = [11, 12, 22, 25, 34, 64, 90];
        Assert.Equal(expected, data);
        Assert.True(comps > 0);
        Assert.True(swaps > 0);
    }

    [Fact]
    public void TestInsertionSort_AlreadySorted()
    {
        int[] data = [1, 2, 3, 4, 5];
        var (comps, swaps) = InsertionSort.Sort(data);

        int[] expected = [1, 2, 3, 4, 5];
        Assert.Equal(expected, data);
        Assert.Equal(4, comps);  // n-1 = 4 comparisons, all early breaks
        Assert.Equal(0, swaps);  // No swaps needed
    }
}
