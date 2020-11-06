using System;
using static Algorithms.Helpers;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };
            int[] array1 = { 6, 1, 2, 3, 4, 5, 0 };

            PrintArray(array);
            MergeSort2(array, 0, array.Length - 1);
            PrintArray(array);

            Console.ReadKey();
        }

        //ITVDN example 1
        public static void MergeSort(int[] items)
        {
            if(items.Length <= 1)
            {
                return;
            }

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            MergeSort(left);
            MergeSort(right);

            Merge(items, left, right);
        }

        //https://www.geeksforgeeks.org/in-place-merge-sort/
        public static void MergeSort2(int[] items, int l, int r)
        {
            //{ 3, 7, 4, - 4, 6, 5, 8 }

            if (l >= r)
            {
                return;
            }

            int m = (l + r) / 2;

            MergeSort2(items, l, (l+r) / 2);
            MergeSort2(items, (l + r) / 2 + 1, r);

            Merge(items, l, m, r);
        }
    }
}
