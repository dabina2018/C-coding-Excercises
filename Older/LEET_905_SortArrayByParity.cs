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
            int front = 0;  // create front pointer at index 0
            int end = A.Length - 1;  // set back(end) pointer to last index of array
            while (front < end)
            {
                if(!IsEven(A[front]))  // if front is Odd 
                {
                    if (IsEven(A[end])) //if end is Even
                    {
                        (A[end], A[front]) = (A[front], A[end]); // if front is Odd and end is Even, swap the values
                        front++; // increment front index/pointer
                        end--;  //decrement back index/pointer                     
                    }
                    else end--; // if front is Odd and end is Odd, decrement back index/pointer
                }
                else
                {
                    if (IsEven(A[end])) front++; //if front is even and end is even, increment front counter/index
                    else // front is even and end is odd
                    {
                        front++; //increment front counter 
                        end--;  //decrement end counter
                    }
                }
            }
            return A; // return sorted array
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

        private static bool IsEven(int num) // method to determin if int is odd or even
        {
            return num % 2 == 0;
        }
    }
}
