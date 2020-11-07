using System;
using static Algorithms.Helpers;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };
            int[] array1 = { 6, 1, 2, 3, 4, 5, 0 };

            PrintArray(array);
            QuickSort(array, 0, array.Length - 1);
            PrintArray(array);

            Console.ReadKey();
        }

        //ITVDN example
        public static void QuickSort(int[] items, int left, int right)
        {
            int i = left, j = right;
            int pivot = items[(left + right) >> 1]; // >> is the same as /2 but for bits

            while(i <= j)
            {
                while(items[i] < pivot)
                {
                    i++;
                }

                while(items[j] > pivot)
                {
                    j--;
                }

                if(i <= j)
                {
                    Swap(items, i, j);
                    i++;
                    j--;
                }
            }

            if(left < j)
            {
                QuickSort(items, left, j);
            }

            if(i < right)
            {
                QuickSort(items, i, right);
            }
        }
    }
}
