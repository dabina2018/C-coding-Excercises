using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordFormedByChar
{
    class Program
    {
        /// <summary>
        /// You are given an array of strings words and a string chars. A string is good if it can be formed by characters from chars(each character can only be used once).Return the sum of lengths of all good strings in words.
        /// </summary>
        static void Main()
        {
            string[] array1 = { "cat", "bt", "hat", "tree" };
            string string1 = "atach";

            string[] array2 = { "hello", "world", "leetcode" };
            string string2 = "welldonehoneyr";
            
            string[] array4 = { "banana", "apple" }; //example 3: each char can only be used once
            string string4 = "ban";

            Console.WriteLine(CountCharacters(array1, string1));
            Console.WriteLine(CountCharacters(array2, string2));
            Console.WriteLine(CountCharacters(array4, string4));
        }

        public static int CountCharacters(string[] words, string chars)
        {
            bool goodword = false;
            int result = 0;

            foreach (var w in words)
            {
                string cmprchars = chars;
                for (int p = 0; p < w.Length; p++)
                {
                    if (cmprchars.Contains(w[p]))
                    {
                        goodword = true;
                        cmprchars = cmprchars.Remove(cmprchars.IndexOf(w[p]),1);
                    }
                    else
                    {
                        goodword = false;
                        break;
                    }
                }
                if (goodword == true) result = result + w.Length;
            }
            return result;
        }
    }
}
