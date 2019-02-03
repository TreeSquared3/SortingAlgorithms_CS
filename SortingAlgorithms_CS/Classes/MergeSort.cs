using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_CS.Classes
{
    static class MergeSort
    {
        public static int[] Sort(int[] input)
        {
            if (input.Count() <= 1) return input;
            
            int[] left = input.Where((c, i) => i % 2 == 0).ToArray();
            int[] right = input.Where((c, i) => i % 2 != 0).ToArray();
            
            left = Sort(left);

            right = Sort(right);

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();

            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count() && rightIndex < right.Count())
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            if (leftIndex < left.Count())
            {
                
                for (int i = leftIndex; i < left.Count(); i++)
                {
                    result.Add(left[i]);
                }

            }
            else if(rightIndex < right.Count())
            {
                for (int i = rightIndex; i < right.Count(); i++)
                {
                    result.Add(right[i]);
                }
            }

            return result.ToArray();
        }

    }
}
