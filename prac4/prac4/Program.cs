using System;

class Program
{
    // Delegate declaration
    public delegate int Compare(int a, int b);

    // Method that uses delegate for sorting
    static void SortArray(int[] arr, Compare compare)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (compare(arr[i], arr[j]) > 0)
                {
                    // Swap
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    // Comparison method (Ascending)
    static int Ascending(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 3 };

        // Passing delegate
        SortArray(arr, Ascending);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}