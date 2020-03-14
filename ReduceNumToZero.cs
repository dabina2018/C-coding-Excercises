using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// This program counts the number of steps it takes to reduce a number to zero.
namespace ReduceNumToZero
{
    class Program
    {
        static void Main()
        {
            int input = 14;
            int input2 = 8;
            int input3 = 123;

            Console.WriteLine(NumberOfSteps(input));
            Console.WriteLine(NumberOfSteps(input2));
            Console.WriteLine(NumberOfSteps(input3));

            Console.ReadLine();
        }

        public static int NumberOfSteps(int num)
        {
            int count = 0;
            while(num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                count++;

            }
            return count;
        }

       

    }

  
}
