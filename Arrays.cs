using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //search online to find AT LEAST 2 different examples for using array.
            //https://stackoverflow.com/questions/3700448/how-to-print-contents-of-array-horizontally

            string[] namez = { "names", "Ana", "Felipe" };
            foreach (var name in namez)
            {
                Console.WriteLine($"Hello {name.ToString()}!");
            }

            //Example 2
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

            // Declare and set array element values.
            string[] weekDays = new string[] { "Sun", "Mo", "Tues", "Wed", "Thurs" };
            foreach (var day in weekDays)
            {
                Console.WriteLine(day.ToString());
            }

            // Alternative syntax.
            int[] array2 = { 1, 2, 3, 4, 5, 6 };

            foreach(var item in array2)
            {
                Console.WriteLine(item.ToString());
            }

            //Example 1
            //https://channel9.msdn.com/Series/CSharp-101/CSharp-Arrays-List-and-Collections

            var names = new List<string> { "names", "Ana", "Felipe" };
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //Alternative
            //for (int i = 0; i < names.Count; i++)
            //{
            //Console.WriteLine($"Hello {names[i].ToUpper()}!");
            //}
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToLower()}!");
            }
            Console.WriteLine(names[1]);


        }
    }
}
