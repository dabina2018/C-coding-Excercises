using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[5];
            myArray[0] = "Daveena M. Cooper";
            myArray[1] = "green";

            CutName(myArray[0]);

             
             /*var myInfo = new List<KeyValuePair<object, object>>();
             myInfo.Add(new KeyValuePair<object, object>("fullName", CutName(myArray[0])));
             myInfo.Add(new KeyValuePair<object, object>("favoriteColor", myArray[1]));
             myInfo.Add(new KeyValuePair<object, object>("github", "https://github.com/dabina2018"));
             
            foreach (var k in myInfo)
                Console.WriteLine(k);
            Console.ReadKey();
            */

            
            HashSet<object> myInfo = new HashSet<object>();
            myInfo.Add(new KeyValuePair<object, object>("fullName", CutName(myArray[0])));
            myInfo.Add(new KeyValuePair<object, object>("favoriteColor", myArray[1]));
            myInfo.Add(new KeyValuePair<object, object>("github", "https://github.com/dabina2018"));

            foreach (var k in myInfo)
                Console.WriteLine(k);
            Console.ReadKey();
            
        }



        static string[] CutName(string name)
        {
            string[] nameArray = name.Split(' ');
            Console.WriteLine($"[{string.Join(", ", nameArray)}]");
            return nameArray;
        }
    }
}  
   
        
 
