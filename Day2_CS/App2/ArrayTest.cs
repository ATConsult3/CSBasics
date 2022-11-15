using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022
{
    class ArrayTest
    {

        private static void PrintIntArray(int[] arr)
        {
            Write("[");
            foreach (int element in arr)
            {
                Write($"{element}, ");
            }
            Write("\b\b]\n");
        }

        private static void FillIntArrayByRandomValues(int[] arr)
        {
            long seed = DateTime.Now.Ticks;
            Random rnd = new Random((int)seed);
            for (int i=0; i<arr.Length; i++ )
            {
                arr[i] = rnd.Next(-1000, 1000);
            }
        }

        public static void Main()
        {
            int[] arr0;
            arr0 = new int[7];

            int[] arr1 = new int[] { -10, 3, 4, 44, 01, 45, 101 };
            arr1[4] = 17;
            
            Write("[");
            for (int i=0; i<arr1.Length; i++) Write($"{arr1[i]}, ");
            Write("\b\b]\n");

            PrintIntArray(arr0);
            FillIntArrayByRandomValues(arr0);
            PrintIntArray(arr0);
            FillIntArrayByRandomValues(arr0);
            PrintIntArray(arr0);


        }


    }
}
