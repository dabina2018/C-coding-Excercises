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
            
            do
            {
                x = y % 10;
                y = y / 10;
                //Console.WriteLine(x);
                sum = sum + x;
                //Console.WriteLine(sum);

                //Console.WriteLine(y);
            } while (y > 0);
            return sum;
            Console.WriteLine(sum);
        }
        

    }
}
