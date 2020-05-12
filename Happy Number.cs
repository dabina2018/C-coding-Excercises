using System;
using System.Linq;

namespace HappyNumber
{
    class Program
    {
        //Happy Number Leet Code problem
        /*A happy number is a number defined by the following process: 
        Starting with any positive integer, replace the number by the sum of the squares of its digits, 
        and repeat the process until the number equals 1 (where it will stay), 
        or it loops endlessly in a cycle which does not include 1. 
        Those numbers for which this process ends in 1 are happy numbers.
        Return True if n is a happy number, and False if not. */
        static void Main(string[] args)
        { 
            Solution solve = new Solution();
            Console.WriteLine(solve.IsHappy(19));
            //Console.WriteLine(solve.IsHappy(16));
        }
    }

    public class Solution 
    {
        public bool IsHappy(int n) 
        {
            int num = n;
            int y = n;
            
            while(num != 1)
            {
                int sum = 0;
                while(num > 0)
                {
                     y = num%10;
                    num = num/10;
                    sum = sum + (Convert.ToInt32(Math.Pow(y,2)));
                }
                num = sum;
                

            }
            
            return true;
            
           
        }
    }
}
