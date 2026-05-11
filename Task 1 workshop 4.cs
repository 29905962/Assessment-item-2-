Task 1 workshop 4
namespace Workshop4;

public static class SelectionSort
{
    // TODO Task 1
    // Implement selection sort (ascending, in-place).
    // Counting rules:
    // - Comparisons: increment once per value comparison (data[j] < data[minIndex]).
    // - Swaps: increment when you perform a real swap (only if minIndex != i).
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

namespace Workshop4;

public static class InsertionSort
{
    // TODO Task 2
    // Implement insertion sort (ascending, in-place).
    // Counting rules:
    // - Comparisons: increment once per value comparison with the key (data[j] > key).
    // - Swaps: treat shifts as swaps;
    //   - increment once per shift (data[j+1] = data[j])
    // Note: the lecture pseudocode combines the boundary check and the value comparison in the while condition.
    // You will need to separate them here so you can count value comparisons explicitly.
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
