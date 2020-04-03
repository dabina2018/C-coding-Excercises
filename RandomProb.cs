using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomProb
{
    class Program
    {
        static void Main()
        {
            int input = 30;
            Console.WriteLine($"[{string.Join(", ", CheckLevel(input))}]");
            //Console.ReadLine();
        }
        static List<int> CheckLevel(int level)
        {
            //var strgList = new StringBuilder();
            var numList = new List<int>();
            for (int i = 1; i <= level; i++)
            {
                numList = LevelFinder(numList);
            }
            return numList;
        }
        static List<int> LevelFinder(List<int> list)
        {
            int i = 0;
            int count = 1;
            var rtrList = new List<int>();


            if (list.Count == 0)
            {
                rtrList.Add(1);
            }
            else
            {
                while (i < list.Count)
                {
                    if (i < list.Count-1)
                    {
                        if (list[i] == list[i+1])
                        {
                            count++;
                            i++;
                        }
                        else
                        {
                            rtrList.Add(count);
                            rtrList.Add(list[i]);
                            count = 1;
                            i++;
                        }
                    }
                    else
                    {
                        i++;
                    }
                    
                }
                rtrList.Add(count);
                rtrList.Add(list[i-1]);
                //count = 1;
                //i++;

            }
                    
            
            return rtrList;
        }
    }
    
}
