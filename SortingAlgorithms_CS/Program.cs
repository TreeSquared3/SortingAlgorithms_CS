using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms_CS.Classes;

namespace SortingAlgorithms_CS
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Random rnd = new Random();

            int[] unsortedList = new int[20000];

            for (int i = 0; i < unsortedList.Length; i++)
            {
                unsortedList[i] = rnd.Next(0, 101);
            }
            
            InsertionSortTest(unsortedList);

            MergeSortTest(unsortedList);

            Console.ReadKey();
        }

        static void InsertionSortTest(int[] unsortedList)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] sortedList = InsertionSort.Sort(unsortedList);

            watch.Stop();

            Console.WriteLine("---Insertion Sort---");
            /*Console.WriteLine("Unsorted list: ");

            foreach (int i in unsortedList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted list: ");

            foreach (int i in sortedList)
            {
                Console.Write(i + " ");
            }*/

            Console.WriteLine("");
            Console.Write("Time taken: ");
            Console.Write(watch.ElapsedMilliseconds + "ms\n");
        }

        static void MergeSortTest(int[] unsortedList)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] sortedList = MergeSort.Sort(unsortedList);

            watch.Stop();

            Console.WriteLine("---Merge Sort---");
            /*Console.WriteLine("Unsorted list: ");

            foreach (int i in unsortedList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted list: ");

            foreach (int i in sortedList)
            {
                Console.Write(i + " ");
            }*/

            Console.WriteLine("");
            Console.Write("Time taken: ");
            Console.Write(watch.ElapsedMilliseconds + "ms\n");
        }

    }
}
