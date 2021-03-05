using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main()
        {
            string myName = "Daveena Cooper";

            string userInput2 = "1 2 3 4 5";

            Problem1(myName);
            Problem2(myName);
            Problem3();
            Problem4(userInput2);
        }

        //Problem 1 (Function Name should be Problem1, invoke/call the function from main method) (5 Points)
        //In this function you need to print your name three times using for loop, 
        //then print your name again three times using While loop.
        static void Problem1(string name)
        {
            //for Loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(name);
            }
            /// while Loop
            int w = 0;
            while (w < 3)
            {
                Console.WriteLine(name);
                w++;
            }return;
        }

        //Problem 2 (Function Name should be Problem2 invoke/call the function from main method)  (5 points)
        //In this function you need to create an array.The first index of the array should have your first name 
        //and the second index of the array should have your last name.
        //Use for loop to print your lastName then your firstName.
        
        static void Problem2(string name)
        {

            string[] nameArray = new string [5];
            int blankPos = name.IndexOf(' ');
            string fName = name.Substring(0, blankPos);
            nameArray[0] = fName;
            string lName = name.Substring(blankPos, (name.Length-fName.Length));
            nameArray[1] = lName;

            for (int i = nameArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(nameArray[i]);
            }
            return;
        }

        //Problem 3 (Function Name should be Problem3)  (5 points)
        //Create a program to ASK the user for 10 integer numbers(from -1000 to 1000), 
        //sort them and display them sorted. (Note you can't use sort or similar function to solve the problem, 
        //You need to write your own code)
        
        
        static void Problem3()
        {
            int[] numArray = new int[10];
            Console.WriteLine("Please enter 10 numbers");
            for (int i = 0; i < 10; i++)
            { 
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"[{string.Join(", ", numArray)}]");

            int len = numArray.Length;
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < len-1; i++)
                {
                    if (numArray[i] > numArray[i + 1])
                    {
                        int tmp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = tmp;
                        swapped = true;
                    }
                }
            } while (swapped == true);

            Console.WriteLine($"[{string.Join(", ", numArray)}]");
        }

        //Problem 4 Problem 4 (Function Name should be HighLow)  (5 points) Create a function that accepts 
        //a string of space separated numbers and returns the highest and lowest number(as a string). 
        //Call invoke the function four times from main method with the following values:
              //HighLow("1 2 3 4 5")    Note: The output should be "5 1" 
              //HighLow("1 2 -3 4 5")   Note: The output should be "5 -3" 
              //HighLow("1 9 3 4 -5")   Note: The output should be "9 -5"
              //HighLow("13")  Note: The output should be "13 13"

        public static void Problem4(string numString)
        {
            int min = 0;
            int max = 0;
            //Console.WriteLine(numString);
            foreach (string n in numString.Split(' '))
            {
               
                if (Convert.ToInt32(n) > max)
                {
                    max = Convert.ToInt32(n);
                }
                if (Convert.ToInt32(n) < min) 
                {
                    min = Convert.ToInt32(n);
                }
            }
            Console.WriteLine("{0} {1}", max, min);
            Console.WriteLine($"{max} {min}");
        }
    }   
}
