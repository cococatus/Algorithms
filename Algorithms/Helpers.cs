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
