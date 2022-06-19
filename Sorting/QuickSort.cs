using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.Sorting
{
    public class QuickSort
    {
        public void Sort(int[] numbers, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            var boundary = Partition(numbers, start, end);
            Sort(numbers, start, boundary - 1); //  left
            Sort(numbers, boundary + 1, end);
        }

        private int Partition(int[] numbers, int start, int end)
        {
            int boundary = start - 1;

            int pivot = numbers[end];

            for (int j = start; j <= end; j++)
            {
                if (numbers[j] <= pivot)
                {
                    boundary++;
                    Swap(numbers, boundary, j);
                }
            }

            return boundary;
        }

        private void Swap(int[] numbers, int boundary, int j)
        {
            var temp = numbers[j];
            numbers[j] = numbers[boundary];
            numbers[boundary] = temp;

        }
    }
}
