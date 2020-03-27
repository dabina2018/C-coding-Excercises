using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDegree
{
    class Program
    {
        static void Main()
        {
            bool condition ;
            do
            {
                Console.WriteLine("Please enter a time between 0000 and 2359 (hours are 0 - 23, min are 0-60).");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 0 && n <= 2359)
                    {
                        if ((n / 100) <= 23 && n % 100 <= 60)
                        {
                            Console.WriteLine(TimeConversion(n));
                            Console.WriteLine(TimeConversionTwo(n));
                            break;
                        }
                        else condition = false;
                    }
                    else condition = false;
                }
                else condition = false;
            } while (!condition);
            
        }
        public static int TimeConversion(int x)
        {
            int hours = x / 100;
            int min = x % 100;
            return Math.Abs((hours * 30) - (min * 6));
        }
        public static int TimeConversionTwo(int x)
        {
            int hours = x / 100;
            int min = x % 100;
            int degree = ((hours * 30) - (min * 6));
            if (degree < 0) return degree *-1;
            else return degree;
        }
    }
}
