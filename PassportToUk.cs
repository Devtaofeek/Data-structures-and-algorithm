using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm
{
    public static class PassportToUk
    {
        public static string FizzBuzz(int num)
        {
            string result;
            if (num % 3 == 0 && num % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                result = "Fizz";
            }
            else if (num % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                return num.ToString();
            }
            return result;
        }


        public static string GetRecipient(string message, int postion)
        {
            var words = message.Split();

            List<string> usernames = new List<string>();
            foreach (var word in words)
            {
                if (word.StartsWith("@"))
                {
                    //Regex.Match();
                    usernames.Add(word.Substring(1));
                }
            }

            if (postion > usernames.Count)
            {
                return string.Empty;
            }
            return usernames[postion - 1];
        }
    }
}