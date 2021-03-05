using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a 32-bit signed integer, reverse digits of an integer.
//32-bit signed integer range: [−231,  231 − 1]
//function returns 0 when the reversed integer overflows.
namespace Leet2
{
    class Program
    {
        static void Main()
        {
            int num1 = 123;
            int num2 = -123;
            int num3 = -120000;
            //var sol = new Solution();
            //sol.Reverse(num2);

            Console.WriteLine(Reverse(num2));
        }
        public static int Reverse(int x)
        {
            if (x is int)
            { //number is acceptable
                string numr = Convert.ToString(x);
                int n = numr.Length - 1;
                string numberStr = "";

                string negnum = Convert.ToString(numr[0]);
                if (negnum == "-")
                {
                    numberStr = numberStr + negnum;
                }

                for (int i = n; i >= 0; i--)
                {
                    string strnum = Convert.ToString(numr[n]);

                    numberStr = numberStr + numr[n];
                    //Console.WriteLine(numberStr);
                    n = n - 1;
                }
                int n2 = numberStr.Length - 1;

                string negnum2 = Convert.ToString(numberStr[n2]);

                if (negnum2 == "-")
                {
                    numberStr = numberStr.Remove(n2, 1);
                    //Console.WriteLine(numberStr);
                }
                //int newnum = Convert.ToInt32(numberStr);
                bool res;
                int a;
                res = int.TryParse(numberStr, out a);
                if (res)
                {
                    int newnum = Convert.ToInt32(numberStr);
                    return newnum;
                }
                else
                {
                    return 0;
                }
             
            }
            else
            {
                //number is not valid
                Console.WriteLine("invaid input");
                return 0;
            }

        }

    }
       
}


