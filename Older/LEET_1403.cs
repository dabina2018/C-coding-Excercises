using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1403. Minimum Subsequence in Non-Increasing Order
namespace LEET5376
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = {4};
            IList<int> result = Solution.MinSubsequence(nums);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Solution
    {
        public static IList<int> MinSubsequence(int[] nums)
        {
            int len = nums.Length;
            IList<int> subSeq = new List<int>();

            if(len == 1)
            {
                 subSeq.Add(nums[0]);
            }
            else
            {
                int[] sortArr = Sort(nums);
                int bPointer = findPointer(sortArr, len);

                for (int p = len - 1; p >= bPointer; p--)
                {
                    subSeq.Add(sortArr[p]);
                }
            }
            
            return subSeq;
        }
        //Sort the Array least to greatest
        static int[] Sort(int[] nums)
        {
            int[] sortArr = new int[nums.Length];
            IList<int> subSeq = new List<int>();
            int len = nums.Length;

            for (int i = 0; i <= len - 1; i++)
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
            return sortArr;
        }

        //find the front Pointer for cut off point
        static int findPointer(int[] sortArr, int len)
        {
            int bPointer = len - 1;
            int fPointer = 0;

            int sumF = sortArr[fPointer];
            int sumB = sortArr[bPointer];

            while (fPointer < bPointer)
            {
                if (sumF >= sumB)
                {
                    bPointer--;
                    if (bPointer == fPointer)
                    {
                        sumF = sumF - sortArr[fPointer];
                        fPointer--;
                        sumB = sumB + sortArr[bPointer];
                        return bPointer;
                    }                
                    sumB = sumB + sortArr[bPointer];
                }
                else
                {
                    fPointer++;
                    if (fPointer == bPointer)
                    {
                        fPointer--;
                        return bPointer;
                    }
                    else sumF = sumF + sortArr[fPointer];
                }
            }
            
            /*Console.WriteLine(sumB );
            Console.WriteLine(sumF);
            Console.WriteLine(bPointer);
            Console.WriteLine(fPointer);*/
            return bPointer;
        }
    }
}


