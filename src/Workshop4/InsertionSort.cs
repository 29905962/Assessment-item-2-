namespace Workshop4;

public static class InsertionSort
{
    /// <summary>
    /// Implement insertion sort (ascending, in-place).
    /// Counting rules:
    /// - Comparisons: increment once per value comparison with the key (data[j] > key).
    /// - Swaps: treat shifts as swaps; increment once per shift (data[j+1] = data[j])
    /// </summary>
    public static (int Comparisons, int Swaps) Sort(int[] data)
    {
        int comparisons = 0;
        int swaps = 0;

        for (int i = 1; i < data.Length; i++)
        {
            int key = data[i];
            int j = i - 1;

            while (j >= 0)
            {
                comparisons++;
                if (data[j] > key)
                {
                    data[j + 1] = data[j];
                    swaps++;
                    j--;
                }
                else
                {
                    break;
                }
            }

            data[j + 1] = key;
        }

        return (comparisons, swaps);
    }
}
