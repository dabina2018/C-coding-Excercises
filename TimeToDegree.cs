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
            //a program to find the degree between the hour hand and minute hand given a time between 0000 and 2359
            bool condition ;
            do
            {
                Console.WriteLine("Please enter a time between 0000 and 2359 (hours are 0 - 23, minutes are 0-60).");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 0 && n <= 2359)  // confirm input is withing given range
                    {
                        if ((n / 100) <= 23 && n % 100 <= 60)  // input should be a valid hour and minute
                        {
                            Console.WriteLine(TimeConversion(n));  // method accounts for hour hand movment betwen minutes
                            Console.WriteLine(TimeConversionTwo(n)); //in this method hand only moves between whole hours
                            break;
                        }
                        else condition = false;
                    }
                    else condition = false;
                }
                else condition = false;
            } while (!condition);  // loop will continue until proper input is entered
        }
        public static double TimeConversion(int x)
        { // method accounts for movment of hour hand for each passing minute
            int min = x % 100;
            double hours = (x / 100);
            double degree = Math.Abs(((hours * 30) -(30 - (min * .5))) - (min * 6));
            if (degree > 180) return (360 - degree) ;
            else return degree;
        }
        public static double TimeConversionTwo(int x)
        { // hour hand is stationary
            int hours = x / 100;
            int min = x % 100;
            double degree = ((hours * 30) - (min * 6));
            if (degree < 0) degree = degree * -1;
            if (degree > 180) return 360 - degree;
            else return degree;
        }
    }
}
