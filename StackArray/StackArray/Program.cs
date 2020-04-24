using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray_Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray myArray = new StackArray();
        }
    }
    public class StackArray
    {
        private int index = 0;
        public int[] Array = new int[10];

        public int[] Pop()
        {
            if (index < 0)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Array.SetValue(null, index - 1);
                index--;
            }
            return Array;
        }
        public int[] Push(int value)
        {
            if (index < 0)
            {
                index++;
                Console.WriteLine("Try Again...");
            }
            else if (index < Array.Length)
            {
                Array[index] = value;
                index++;
            }
            else
            {
                Console.WriteLine("The Array is full");
            }
            return Array;
        }
        public int Peek()
        {
            Console.WriteLine(Array[index - 1]);
            return Array[index];
        }
        public void Print()
        {
            Console.WriteLine($"[{string.Join(",", Array)}]");
        }

        public int[] Resize(int size)
        {
            if (size < Array.Length)
            {
                string response = "no";
                while (response != "yes")
                {
                    Console.WriteLine("You have entered a size smaller than the original Array, is this correct?  (yes/no)");
                    response = Console.ReadLine();
                    if (response == "yes")
                    {
                        //TO DO: add exception handling for differently sized arrays
                        int[] temp = new int[size];
                        //Array.CopyTo(temp, 0);
                        //alternate copyTo
                        for (int i = 0; i < Array.Length - 1; i++)
                        {
                            temp[i] = Array[i];
                            i++;
                        }
                        Array = temp;
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("Please enter a size for the new Array.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no");
                    }
                }
            }
            return Array;
        }
    }
}
