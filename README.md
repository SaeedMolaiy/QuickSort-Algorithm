# Quick Sort Algorithm

Quick Sort is a popular and efficient sorting algorithm based on the divide-and-conquer strategy. It works by selecting a "pivot" element from the array and partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot. The sub-arrays are then sorted recursively.

## How Quick Sort Works

Quick Sort can be summarized in the following steps:

1. **Select a Pivot Element**: Choose a pivot element from the array.

2. **Partition the Array**: Rearrange the elements so that all elements less than the pivot come before it, and all elements greater than the pivot come after it. The pivot is now in its correct sorted position.

3. **Recursion**: Recursively apply the Quick Sort algorithm to the sub-arrays created in the previous step.

4. **Combine Sub-Arrays**: As the recursion unwinds, the sub-arrays will be sorted, and you can combine them to get the final sorted array.
