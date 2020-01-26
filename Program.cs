using System;
using System.Diagnostics;

namespace sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] arr    = new int[100000];
            int[] sorted = new int[arr.Length];
            Random ran = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(0, 10000);
            }

            Sort(arr, ref sorted);
            //Debug(arr, ref sorted);
        }

        private static void Debug(int[] arr, ref int[] sorted){
            System.Diagnostics.Stopwatch sw = new Stopwatch();

            Console.Write("Not sorted array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+" ");

            Console.WriteLine();
            Console.Write("Sorted          : ");
            
            sw.Start();
            SortMode(arr, ref sorted);
            sw.Stop();

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i]+" ");
            }
            Console.WriteLine();
            sw.Stop();
            Console.WriteLine("Done:"+(sw.ElapsedMilliseconds/100.0).ToString());
        }

        private static void Sort(int[] arr, ref int[] sorted){
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            
            sw.Start();
            SortMode(arr, ref sorted);
            sw.Stop();

            Console.WriteLine();
            sw.Stop();
            Console.WriteLine("Done:"+(sw.ElapsedMilliseconds/100.0).ToString());
        }

        private static void SortMode(int[] arr, ref int[] sorted){
            sorted = Sorts.RadixSort(arr);
            //sorted = Sorts.BubbleSort(arr);
        }
    }
}
