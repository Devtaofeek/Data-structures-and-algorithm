using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.Sorting
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minpos = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[minpos] > arr[j])
                    {
                        minpos = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[minpos];
                arr[minpos] = temp;

            }
        }
    }
}
