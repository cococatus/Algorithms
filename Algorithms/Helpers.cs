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

        public static int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEndIndex)
        {
            int currentSmallest = items[sortedRangeEndIndex];
            int currentSmallestIndex = sortedRangeEndIndex;

            for (int i = sortedRangeEndIndex + 1; i < items.Length; i++)
            {
                if(currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }

        public static void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0, rightIndex = 0, targetIndex = 0;
            int remaining = left.Length + right.Length;

            while(remaining > 0)
            {
                if(leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }

                else if(rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else if(left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                remaining--;
            }
        }

        //https://www.geeksforgeeks.org/in-place-merge-sort/
        public static void Merge(int[] items, int left, int mid, int right)
        {
            int target = mid + 1;        

            // If the direct merge is already sorted 
            if (items[mid] <= items[target])
            {
                return;
            }

            while (left <= mid && target <= right)
            {
                // If element 1 is in right place 
                if (items[left] <= items[target])
                {
                    left++;
                }
                else
                {
                    int value = items[target];
                    int index = target;

                    // Shift all the elements between element 1 
                    // element 2, right by 1. 
                    while (index != left)
                    {
                        items[index] = items[index - 1];
                        index--;
                    }
                    items[left] = value;

                    // Update all the pointers 
                    left++;
                    mid++;
                    target++;
                }
            }
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
