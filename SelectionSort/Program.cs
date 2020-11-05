using System;
using static Algorithms.Helpers;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };

            PrintArray(array);
            SelectionSort(array);
            PrintArray(array);

            Console.ReadKey();
        }

        //ITVDN example
        public static void SelectionSort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);
                sortedRangeEnd++;
            }
        }
    }    
}
