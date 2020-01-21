using System;

namespace sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr  = new int[50];
            int[] sorted = new int[50];
            Random ran = new Random();
            //Sorts sorts = new Sorts();
            Console.WriteLine(0xFF);
            Console.Write("Not sorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(0, 1000);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.Write("Sorted          : ");

            sorted = Sorts.RadixSort(arr);

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Done");
        }
    }
}
