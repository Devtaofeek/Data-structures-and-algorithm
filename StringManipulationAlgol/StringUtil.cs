using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_structures_and_algorithm.StringManipulationAlgol
{
    public static class StringUtil
    {
        public static int CountVowels(string sentence)
        {
            int count = 0;
            if (string.IsNullOrEmpty(sentence))
            {
                return count;
            }
            var vowels = "aeiou";

            foreach (var charr in sentence.ToLower())
            {
                if (vowels.Contains(charr))
                {
                    count++;
                }
            }

            return count;
        }

        public static string Reverse(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }
            var reversed = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed.Append(word[i++]);
            }

            return reversed.ToString();
        }

        public static string ReverseWord(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;
            var words = sentence.Trim().Split(" ").ToList();
            words.Reverse();
            return string.Join(" ", words);
        }

        public static string ReverseWordUsingArr(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;
            var words = sentence.Trim().Split(" ");
            var reversed = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed.Append(words[i] + " ");
            }

            return reversed.ToString();
        }

        public static bool Rotations(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return false;
            }

            return str1.Length == str2.Length && (str1 + str2).Contains(str2);
        }

        public static string StringRotationToTheRight(string word, int by)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            string[] B = new string[word.Length];
            //ABCD
            for (int i = 0; i < by; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    B[word.Length - 1 - j] = word[j].ToString();
                }
            }
            return string.Join("", B);
        }

        public static string RemoveDuplicates(string word)
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            var map = new HashSet<string>();
            foreach (var item in word)
            {
                map.Add(item.ToString());
            }

            return string.Join("", map);
        }

        public static char getMaxOccuringChar(string str)
        {
            int[] freq = new int[256];

            for (int i = 0; i < str.Length; i++)
            {
                freq[str[i]]++;
            }
            int max = 0;
            var result = ' ';
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > max)
                {
                    max = freq[i];
                    result = (char)i;
                }
            }
            return result;
        }
    }
}