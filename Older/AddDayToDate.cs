using System;

namespace AddDaytoDate
{
    class Program
    {
        static void Main(string[] args)
        {
                // Ask the user to enter a date
                Console.Write("Enter a month: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a day: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a year: ");
                int y = Convert.ToInt32(Console.ReadLine());

                // display the current date
                Console.WriteLine($"Your current date is : {m}-{d}-{y}\n");

                // Ask the user how many days they want to add
                Console.Write("Enter the number of days you'd like to add: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // calculate the new day
                int newDay = d + a;

                while (true)
                {
                    //Console.WriteLine($"{m}-{newDay}-{y}");

                    var daysOfMonth = new[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    if (IsLeapYear(y))
                        daysOfMonth[2] = 29;

                    if (newDay > daysOfMonth[m])
                    {
                        if (m != 12)
                        {
                            newDay = newDay - daysOfMonth[m];
                            m = m + 1;
                            continue;
                        }
                        else
                        {
                            newDay = newDay - daysOfMonth[m];
                            m = 1;
                            y = y + 1;
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The new date is: {m}-{newDay}-{y}");
                        break;
                    }
                }
            }

            public static bool IsLeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }


        
    }
}
