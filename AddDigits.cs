using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 38;
            int digit2 = 12345;

            Console.WriteLine(AddDigits(digit));
            Console.WriteLine(AddDigits(digit2));
        }

        static int AddDigits(int y)
        {
            int x;
            int sum = 0;

            while (y > 9)
            {
                sum = 0;
                while (y > 0)
                {
                    x = y % 10;
                    y = y / 10;
                    sum = sum + x;
                    //Console.WriteLine(sum);
                }
                y = sum;
            } 
            return sum;
            //Console.WriteLine(sum);
        }
        

    }
}
