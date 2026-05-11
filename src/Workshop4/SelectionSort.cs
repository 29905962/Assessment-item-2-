namespace Workshop4;

public static class SelectionSort
{
    /// <summary>
    /// Implement selection sort (ascending, in-place).
    /// Counting rules:
    /// - Comparisons: increment once per value comparison (data[j] < data[minIndex]).
    /// - Swaps: increment when you perform a real swap (only if minIndex != i).
    /// </summary>
    public static (int Comparisons, int Swaps) Sort(int[] data)
    {
        int comparisons = 0;
        int swaps = 0;

        for (int i = 0; i < data.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < data.Length; j++)
            {
                comparisons++;
                if (data[j] < data[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (data[i], data[minIndex]) = (data[minIndex], data[i]);
                swaps++;
            }
        }

        return (comparisons, swaps);
    }
}
