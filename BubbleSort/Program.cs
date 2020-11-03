using System;
using static Algorithms.Helpers;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };

            PrintArray(array);
            BubbleSort(ref array);
            PrintArray(array);

            Console.ReadKey();
        }

        //ITVDN example
        public static void BubbleSort(ref int[] items)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 1; i < items.Length; i++)
                {
                    if(items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            }
            while (swapped != false);
        }
    }    
}
