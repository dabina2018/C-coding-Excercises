using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiran_LQ_3
{
    class Program
    {
        static void Main()
        {
            int input = 1;
            int input2 = 154451;
            int input3 = 123123;
            int input4 = 121;
            int input5 = -121;

            Console.WriteLine(IsPalindrome(input));
            Console.WriteLine(IsPalindrome(input2));
            Console.WriteLine(IsPalindrome(input3));
            Console.WriteLine(IsPalindrome(input4));
            Console.WriteLine(IsPalindrome(input5));
        }

        public static bool IsPalindrome(int x)
        {
            bool plndr = false;
            int origx = x;
            int remainder;
            int result = 0;

            if (x < 0)
            {
                plndr = false;
            }
            else if (x == 0)
            {
                plndr = true;
            }
            else if (x<= 9)
            {
                plndr = true;
            }
            else
            {
                while (x > 0)
                {
                    remainder = (x%10);
                    result = remainder + result * 10;
                    x /= 10;
                }
                if (result == origx)
                {
                    plndr = true;
                }
                else
                {
                    plndr = false;
                }
            }
            return plndr;
            Console.ReadLine();

        }

    }
}
