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
            InsertionSortTest();

            Console.ReadKey();
        }

        static void InsertionSortTest()
        {
            Random rnd = new Random();

            int[] unsortedList = new int[9];

            for (int i = 0; i < unsortedList.Length; i++)
            {
                unsortedList[i] = rnd.Next(0, 101);
            }


            int[] sortedList = InsertionSort.Sort(unsortedList);

            Console.WriteLine("---Insertion Sort---");
            Console.WriteLine("Unsorted list: ");

            foreach (int i in unsortedList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted list: ");

            foreach (int i in sortedList)
            {
                Console.Write(i + " ");
            }
        }

    }
}
