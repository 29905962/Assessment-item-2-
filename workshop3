Task 1 workshop 3 
public static (int Index, int Steps) BinarySearchDescendingIterativeWithSteps(int[] a, int target)
{
    int low = 0;
    int high = a.Length - 1;

    int steps = 0;

    while (low <= high)
    {
        int mid = (low + high) / 2;

        // One midpoint inspection
        steps++;

        if (a[mid] == target)
        {
            return (mid, steps);
        }

        // DESCENDING ORDER logic
        if (target > a[mid])
        {
            high = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }

    return (-1, steps);
}


Task 2 
private static (int Index, int Steps)
BinarySearchDescendingRecursiveWithSteps(
    int[] a,
    int target,
    int low,
    int high,
    int stepsSoFar)
{
    // Base case: not found
    if (low > high)
    {
        return (-1, stepsSoFar);
    }

    int mid = (low + high) / 2;

    // Count midpoint inspection
    stepsSoFar++;

    // Found target
    if (a[mid] == target)
    {
        return (mid, stepsSoFar);
    }

    // DESCENDING ORDER logic
    if (target > a[mid])
    {
        return BinarySearchDescendingRecursiveWithSteps(
            a,
            target,
            low,
            mid - 1,
            stepsSoFar);
    }
    else
    {
        return BinarySearchDescendingRecursiveWithSteps(
            a,
            target,
            mid + 1,
            high,
            stepsSoFar);
    }
}

Task 3 — Compare Iterative vs Recursive

The tests should confirm:

 Same index returned
 Same step count
Same search behaviour

Because both versions implement the same algorithm.

Example Comparison

Array:

[100, 80, 60, 40, 20]


Target:

40


Both implementations should return:

Index = 3
Steps = 2

Step Counting

You only count:

inspection of A[mid]


That means:

iterative → once per loop
recursive → once per recursive call

NOT:

comparisons separately
boundary checks
recursive calls without midpoint inspection
Time Complexity

Binary search repeatedly halves the search space:

O(logn)

Very efficient even for large arrays.

Key Difference Between Versions
Iterative	Recursive
Uses loops	Uses recursive calls
Less memory	Uses call stack
Often faster	Often cleaner/readable

But both should produce:

identical indices
identical step counts
identical search paths