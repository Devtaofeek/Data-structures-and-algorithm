using System;
using System.Linq;
using System.Text;

namespace Data_structures_and_algorithm.StringManipulationAlgol
{
    public class StringUtils
    {
        public static int CountVowels(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            int count = 0;
            var vowels = "aeiou";
            foreach (var item in str)
            {
                if (vowels.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }


        public static string ReverseStringThree(string str)
        {
            if (str == null)
            {
                return string.Empty;
            }
            var builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            return builder.ToString();

        }

        public static string ReverseASentence(string sentence)
        {
            return sentence == null ? string.Empty : string.Join(" ", sentence.Trim().Split(" ").Reverse());
        }


        public static char Mostrepeated(string str1)
        {
            if (string.IsNullOrEmpty(str1))
            {
                return default;
            }

            var dic = new Dictionary<char, int>();

            foreach (var item in str1)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] = dic[item] + 1;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            var result = default(char);
            var max = int.MinValue;
            foreach (var item in dic)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }

            return result;
        }

        public static char MostRepeated(string str)
        {
            var arr = str.ToCharArray();
            var freq = new int[256];


            for (int i = 0; i < str.Length; i++)
            {
                freq[str[i]] = freq[str[i]] + 1;
            }

            return ' ';
        }

        public static bool AreAnagrams(string one, string two)
        {
            var stone = one.OrderBy(a => a);
            var sttwo = two.OrderBy(a => a);

            return stone.SequenceEqual(sttwo); // you can also check if they have the same frequency
        }

        public static bool Ispalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            var left = 0;
            var right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public int maximumSubArray(int[] arr)
        {
            // 2 , 3, 4, 5, 7
            var current = arr[0];
            var global = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (current < 0)
                {
                    current = arr[i];
                }
                else
                {
                    current += arr[i];
                }

            if (global < current)
            {
                global = current;
            }

            return global;
        }
    }
}


