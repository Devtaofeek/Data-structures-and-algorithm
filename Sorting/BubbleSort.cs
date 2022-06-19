using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.Sorting
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            bool isSorted;
            for (int i = 0; i < arr.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        isSorted = false;
                    }
                }

                if (isSorted)
                {
                    return;
                }
            }
        }

    }
}
