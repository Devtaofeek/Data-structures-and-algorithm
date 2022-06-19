using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm
{
    public class Tdic
    {
        public char FirstNonRepeater(string sentence)
        {
            var dic = new Dictionary<char, int>();

            foreach (var item in sentence)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }
            }

            foreach (var item in dic)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return default;
        }

        public char FirstRepeatedChar(string sentence)
        {
            var charSet = new HashSet<char>();
            foreach (var item in sentence)
            {
                if (charSet.Contains(item))
                {
                    return item;
                }
                else
                {
                    charSet.Add(item);
                }
            }

            return default;
        }
    }
}
