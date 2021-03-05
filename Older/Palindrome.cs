using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            do
            {
                Console.WriteLine("Please enter a word");
                userinput = Console.ReadLine();
                PalindromeTest(userinput);
                //PalindromeTest("racecar");
            } while (userinput != "quit");


        }

        static bool PalindromeTest(string word)
        {
            int l = word.Length - 1;
            int n = word.Length / 2;
            bool palindrome = false;

            for (int i = 0; i < n; i++)
            {
                if (word[i] == word[l])
                {
                    palindrome = true;
                    l--;
                }
                else
                {
                    palindrome = false;
                }
            }
            Console.WriteLine(palindrome);
            return palindrome;        
        }
    }
}
