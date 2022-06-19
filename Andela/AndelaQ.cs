using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.Andela
{
    internal class AndelaQ
    {
        public static int NumPlayers(int k, List<int> scores)
        {
            scores.Sort();
            scores.Reverse();

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < scores[i - 1])
                {
                    if (i + 1 > k)
                    {
                        return i;
                    }
                }
            }

            return scores.Count;

        }

        public static int ParkingDilema(List<int> Cars, int k)
        {
            Cars.Sort();
            Index index = ^1;
            var indexvalue = Cars[^1];
            int minLength = Cars[index] - Cars[0];
            for (int i = 0; i < Cars.Count; i++)
            {
                if (i > Cars.Count - k - 1)
                {
                    return minLength;
                }

                var further = Cars[i + k - 1];
                var before = Cars[i];
                var currentLength = further - before + 1;
                if (minLength > currentLength)
                {
                    minLength = currentLength;
                }
            }

            return minLength;
        }

        public static int piler(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                var daystock = arr[i];


                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > daystock)
                    {
                        var dd = arr[j] - daystock;
                        if (dd > max)
                        {
                            max = dd;
                        }
                    }
                }

            }
            if (max > 0)
            {
                return max;
            }
            else
            {
                return -1;
            }

        }


        public static void StrangeSortingProblem(List<int> mappings, List<string> nums)
        {
            var dic = new Dictionary<string, string>();

            for (int i = 0; i < mappings.Count; i++)
            {
                dic[mappings[i].ToString()] = i.ToString();
            }

            var result = new List<int>();
            foreach (var item in nums)
            {
                var str = string.Empty;
                foreach (var cg in item)
                {
                    str += dic[cg.ToString()];
                }
                result.Add(int.Parse(str));

                result.Sort();

            }

        }
    }
}
