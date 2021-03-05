using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    class Program
    {
        public static void Main()
        {
            int[] givenNum = new int[] { 2, 7, 11, 15 };
            int trgtNum = 9;

            Solution solution = new Solution();

           // int[] result = solution.TwoSum(givenNum, trgtNum);
            Console.WriteLine(string.Join(" ",solution.TwoSum(givenNum, trgtNum)));
            

        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] numz = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                
               for (int j = i+1; j < nums.Length; j++)
                {
                   if (diff == nums[j])
                     {
                        numz[0] = i;
                        numz[1] = j;
                        //Console.WriteLine(numz[0:2]);
                     }
                        
               }
                
            }
            return numz;
        }
    }

}



