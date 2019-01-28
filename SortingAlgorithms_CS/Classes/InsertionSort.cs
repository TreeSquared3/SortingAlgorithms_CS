using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_CS.Classes
{
    static class InsertionSort
    {

        public static int[] Sort(int[] inputList)
        {
            List<int> newList = new List<int>();

            newList.Add(inputList[0]);

            for(int i=1;i<inputList.Length;i++)
            {
                for(int u = i-1; u >= 0; u--)
                {
                    if (inputList[i] > newList[u])
                    {
                        newList.Insert(u + 1, inputList[i]);
                        break;
                    }
                    else if (u == 0) newList.Insert(0, inputList[i]);
                    
                }
            }

            return newList.ToArray();
        }
        
    }
}
