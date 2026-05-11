namespace Workshop3;

public static class BinarySearch
{
    /// <summary>
    /// Iterative binary search on descending array with step counting.
    /// </summary>
    public static (int Index, int Steps) BinarySearchDescendingIterativeWithSteps(int[] a, int target)
    {
        int low = 0;
        int high = a.Length - 1;
        int steps = 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            steps++; // One midpoint inspection

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

    /// <summary>
    /// Recursive binary search on descending array with step counting.
    /// </summary>
    public static (int Index, int Steps) BinarySearchDescendingRecursiveWithSteps(
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
        stepsSoFar++; // Count midpoint inspection

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
}
