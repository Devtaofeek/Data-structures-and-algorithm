using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_structures_and_algorithm
{
    public class GsQuestions
    {
        public static void Maxmin(int[] arr, int size)
        {
            int maxIdx = size - 1;
            int minIdx = 0;
            int maxElem = arr[maxIdx] + 1; // store any element that is greater than the maximum element in the array 
            for (int i = 0; i < size; i++)
            {
                // at even indices we will store maximum elements
                if (i % 2 == 0)
                {
                    var i1 = arr[maxIdx];
                    var elem = i1 % maxElem;
                    arr[i] += elem * maxElem;
                    maxIdx -= 1;
                }
                else
                { // at odd indices we will store minimum elements
                    var i1 = arr[minIdx];
                    var elem = i1 % maxElem;
                    arr[i] += elem * maxElem;
                    minIdx += 1;
                }
            }
            // dividing with maxElem to get original values.
            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i] / maxElem;
            }
        }

        public static int MinumumMovesGs(int[] andres, int[] marea)
        {

            // pick the first two values at index i 
            var count = 0;

            // [123, 543] and Maria's = [321, 279].
            for (int i = 0; i < andres.Length; i++)
            {
                var andresIntTostring = andres[i].ToString();
                var mareaIntToString = marea[i].ToString();

                for (int j = 0; j < andresIntTostring.Count(); j++)
                {

                    var mValue = char.GetNumericValue(mareaIntToString[j]);
                    var aValue = char.GetNumericValue(andresIntTostring[j]);
                    if (mValue > aValue)
                    {
                        var diff = (int)(mValue - aValue);
                        count += diff;
                    }
                    else if (mValue < aValue)
                    {
                        var diff = (int)(aValue - mValue);
                        count += diff;
                    }
                }
            }

            return count;
        }
    }
}
