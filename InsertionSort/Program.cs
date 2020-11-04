using System;
using static Algorithms.Helpers;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };
            int[] array1 = { 6, 1, 2, 3, 4, 5, 0 };

            PrintArray(array1);
            MyInsertionSort(array1);
            PrintArray(array1);

            Console.ReadKey();
        }

        //ITVDN example
        public static void InsertionSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while(sortedRangeEndIndex < items.Length)
            {
                if(items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        public static void MyInsertionSort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                if(items[i].CompareTo(items[i - 1]) < 0)
                {
                    var insertIndex = FindInsertionIndex(items, items[i]);
                    Insert(items, insertIndex, i);
                }
            }
        }
    }
}
