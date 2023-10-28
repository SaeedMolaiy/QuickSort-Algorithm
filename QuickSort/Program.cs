int[] arr = { 16, 4, 17, 6, 7, 3, 1, 15 };

Console.WriteLine("Original Array:");
PrintArray(arr);

QuickSort.QuickSort.QuickSortAlgorithm(arr, 0, arr.Length - 1);

Console.WriteLine("\nSorted Array:");
PrintArray(arr);
  
Console.ReadKey();

static void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}