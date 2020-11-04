using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Helpers
    {
        static void Main(string[] args) { }

        public static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                var temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                    return i;
            }

            throw new InvalidOperationException($"Index not found. There is no value greater than {valueToInsert}");
        }

        /*
         * 1. Save value at index 'to' 
         * 2. Insert value 'from' at index 'to'
         * 3. Shift array to the right from 'to'+1
         * 4. Place saved value at 'to'+1
         */
        public static void Insert(int[] items, int to, int from)
        {
            int temp = items[to];
            items[to] = items[from];

            //going backwards from 'from' index to 'to'+1
            for (int i = from; i > to; i--)
                items[i] = items[i - 1];

            items[to + 1] = temp;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
