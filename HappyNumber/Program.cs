using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
                Console.WriteLine(solve.IsHappy(16));
            }
        }

    public class Solution
    {
        public bool IsHappy(int n)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            Task<bool> task1 = Task.Run<bool>(() =>FindSum(n, ct), ct);

            task1.Wait(10000);
            //request cancellation

            if (task1.IsCompleted)
            {
                return true;
            }
            else
            {
                cts.Cancel();
                return false;
            }
        }

        public bool FindSum(int n, CancellationToken ct)
        {
            int num = n;
            int y = n;

            while (num != 1)
            {
                int sum = 0;
                while (num > 0)
                {
                    y = num % 10;
                    num = num / 10;
                    sum = sum + (Convert.ToInt32(Math.Pow(y, 2)));

                    //check for cancellation
                    ct.ThrowIfCancellationRequested();
                }
                num = sum;
            }
            return true;
        }



    }

        
}


