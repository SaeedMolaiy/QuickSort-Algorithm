namespace QuickSort;

internal class QuickSort
{
    public static void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        var pivotIndex = Partition(array, left, right);

        QuickSortAlgorithm(array, left, pivotIndex - 1);
        QuickSortAlgorithm(array, pivotIndex + 1, right);
    }

    public static int Partition(int[] array, int left, int right)
    {
        var pivot = array[right];
        var i = left - 1;

        for (var j = left; j < right; j++)
        {
            if (array[j] >= pivot)
            {
                continue;
            }

            i++;

            (array[i], array[j]) = (array[j], array[i]);
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);

        return i + 1;
    }
}