using System;

public class Merger
{
    public static T[] MergeSortedArrays<T>(T[] firstArray, T[] secondArray)
        where T : IComparable<T>
    {
        int firstIndex = 0;
        int secondIndex = 0;
        int resultIndex = 0;

        T[] mergedResult = new T[firstArray.Length + secondArray.Length];

        // Compare elements from both arrays one by one
        while (firstIndex < firstArray.Length && secondIndex < secondArray.Length)
        {
            if (firstArray[firstIndex].CompareTo(secondArray[secondIndex]) <= 0)
            {
                mergedResult[resultIndex] = firstArray[firstIndex];
                firstIndex++;
            }
            else
            {
                mergedResult[resultIndex] = secondArray[secondIndex];
                secondIndex++;
            }

            resultIndex++;
        }

        // Copy remaining elements from first array (if any)
        while (firstIndex < firstArray.Length)
        {
            mergedResult[resultIndex] = firstArray[firstIndex];
            firstIndex++;
            resultIndex++;
        }

        // Copy remaining elements from second array (if any)
        while (secondIndex < secondArray.Length)
        {
            mergedResult[resultIndex] = secondArray[secondIndex];
            secondIndex++;
            resultIndex++;
        }

        return mergedResult;
    }

    // Example usage
    public static void Main()
    {
        int[] a = { 1, 4, 7, 10 };
        int[] b = { 2, 3, 6, 9 };

        int[] merged = MergeSortedArrays(a, b);

        foreach (int value in merged)
        {
            Console.Write(value + " ");
        }
    }
}
