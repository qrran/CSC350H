using System;

namespace SelectionSort
{
    internal class Program
    {
        // all methods should be static
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 4, 2 };
            SelectionSort(ref arr1);
            foreach (int num in arr1)
                Console.WriteLine(num);
        }

        // method here

        // public class Lab4Q1 // class name
        // {
        //     int minValue;
        //     int minIndex;

        static private void SelectionSort(ref int[] arr1)
        {
            int minValue;
            int minIndex;
            // outer loop
            for (int startScan = 0; startScan < arr1.Length - 1; startScan++)
            {
                minIndex = startScan;
                minValue = arr1[minIndex];
                // inner loop
                for (int index = startScan + 1; index < arr1.Length; index++)
                {
                    if (arr1[index] < minValue)
                    {
                        minValue = arr1[index];
                        minIndex = index;
                    }
                }
                Swap(ref arr1[minIndex], ref arr1[startScan]);
            }

        }

        static private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // }
    }
}