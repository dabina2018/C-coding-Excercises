using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET5376
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = { 4, 3, 10, 9, 8 };
            IList<int> result = Solution.MinSubsequence(nums);
        }
    }

    public class Solution
    {
        public static IList<int> MinSubsequence(int[] nums)
        {
            int[] sortArr = new int[nums.Length];
            IList<int> subSeq = new List<int>();
            int len = nums.Length;
            
            for (int i = 0; i <= len-1; i++)
            {
                int lowNum = nums[i];
                for (int j = i; j < len; j++)
                {
                    int tmp;
                    if (lowNum > nums[j])
                    {
                        lowNum = nums[j];
                        tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                    }
                }
                sortArr[i] = lowNum;
            }
            /*foreach (var item in sortArr)
            {
                System.Console.WriteLine(item);
            }*/
            
            int bPointer = len-1;
            int fPointer = 0;

            int sumF = sortArr[fPointer];
            int sumB = sortArr[bPointer];

            for (int k = 0; k <= bPointer; k++)
            {
                if (sumF >= sumB)
                {
                    bPointer--;
                    sumB = sumB + sortArr[bPointer];
                    sumF = sumF - sortArr[fPointer];
                    fPointer--;
                }
                else
                {
                    fPointer++;
                    sumF = sumF + sortArr[fPointer];
                }
            }
            //Console.WriteLine(sumB );
            //Console.WriteLine(sumF);
            //Console.WriteLine(bPointer);
            //Console.WriteLine(fPointer);

            
            for (int p = len-1; p >fPointer; p--)
            {
                subSeq.Add(sortArr[p]);
            }
            return subSeq;
        }
    }
}


