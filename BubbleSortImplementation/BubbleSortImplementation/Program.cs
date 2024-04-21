using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        BubbleSort(arr);

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    public static void BubbleSort<T>(T[] arr, IComparer<T> comparer = null) where T : IComparable
    {
        if (comparer == null)
        {
            comparer = Comparer<T>.Default;
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}