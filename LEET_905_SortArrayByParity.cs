using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParity
{
    class Program
    {
        //Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.
        //You may return any answer array that satisfies this condition.

        static void Main()
        {
            int[] A = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", SortArray(A)));
            Console.WriteLine(string.Join(", ", Solution(A)));
        }

        static int[] SortArray(int[] A)
        {
            int front = 0;
            int end = A.Length - 1;
            while (front < end)
            {
                if(!IsEven(A[front]))
                {
                    if (IsEven(A[end]))
                    {
                        (A[end], A[front]) = (A[front], A[end]);
                        front++;
                        end--;                        
                    }
                    else end--;
                }
                else
                {
                    if (IsEven(A[end])) front++;
                    else
                    {
                        front++;
                        end--;
                    }
                }
            }
            return A;
        }

        static int[] Solution(int[] array)
        { 
            int[] resArray = new int[array.Length];
            int j = 0;
            int k = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) resArray[j++] = array[i];
                else resArray[--k] = array[i];
            }
            return resArray;
        }

        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
