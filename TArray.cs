using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm
{
    public class TArray
    {

        int[] array;
        int count = 0;
        int n;
        public TArray(int n)
        {
            array = new int[n];
            this.n = n;
        }


        public void Insert(int item)
        {
            if (count == n)
            {
                var newArray = new int[n * 2];
                array.CopyTo(newArray, 0);
                array = newArray;
            }
            array[count] = item;
            count += 1;
        }


        public void removeAt(int index)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            count -= 1;
        }


        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
