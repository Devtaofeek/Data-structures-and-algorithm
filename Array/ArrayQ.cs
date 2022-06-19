using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.Array
{
    internal class ArrayQ
    {
        public static int[] FindSumBySortingArray(int[] arr, int value)
        {
            var QuickSort = new QuickSort();
            QuickSort.Sort(arr, 0, arr.Length - 1);

            var pointerOne = 0;

            var result = new int[2];

            var pointerTwo = arr.Length - 1;

            foreach (var t in arr)
            {
                var sum = arr[pointerOne] + arr[pointerTwo];

                if (sum > value)
                {
                    pointerOne++;
                }
                else if (sum < value)
                {
                    pointerTwo--;
                }
                else
                {
                    result[0] = pointerOne;
                    result[1] = pointerTwo;
                    return result;
                }
            }
            return arr;
        }

        public static int[] FindSumByHashSet(int[] arr, int value)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                var res = value - arr[i];
                if (set.Contains(res))
                {
                    return new[] { res, arr[i] };
                }
                else
                {
                    set.Add(arr[i]);
                }
            }

            return Array.Empty<int>();
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        public static int Fac(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Fac(n - 1);
        }

        public static void FindProduct(int[] arr)
        {
            var ans = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                int pro = 1;
                for (var j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        pro *= arr[j];
                    }
                }
                ans[i] = pro;
            }
        }

        public static int FindTheMinimumValueInArray(int[] arr)
        {
            var initialmin = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (initialmin > arr[i])
                {
                    initialmin = arr[i];
                }
            }

            return initialmin;
        }

        public static int FirstUniqueInteger(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }

            return -1;
        }

        public static int FindSecondmax(int[] arr)
        {
            var secondmax = Int32.MinValue;
            var b = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (secondmax < arr[i])
                {
                    b = secondmax;
                    secondmax = arr[i];
                }
                else if (b < arr[i])
                {
                    b = arr[i];
                }
            }

            return b;
        }

        public static void RotateArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = arr[i - 1];
            }

            newArr[0] = arr[arr.Length - 1];
        }

        public static int MaximumSubArray(int[] arr)
        {
            // 2, 4, 5, 6, -3. -2, 5, -6
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentMax = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    currentMax += arr[j];

                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                }
            }

            return max;
        }

        public static int MaxSumArrByKadane(int[] arr)
        {
            if (arr.Length < 1)
            {
                return 0;
            }

            int currMax = arr[0];
            int globalMax = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (currMax < 0)
                {
                    currMax = arr[i];
                }
                else
                {
                    currMax += arr[i];
                }

                if (globalMax < currMax)
                {
                    globalMax = currMax;
                }
            }
            return globalMax;
        }
    }
}
