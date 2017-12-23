/*
 * 14. Time + 15 Minutes
 * 
 * Write a program that reads hour and minute of 24-hour user input and calculates how long it 
 * will be after 15 minutes. Print the result in hh: mm format. Hours are always between 0 and 23, 
 * and minutes are always between 0 and 59. Hours are written in one or two digits. 
 * Minutes are always written in two digits, leading zero when needed.
 * 
 * Example:
 * Input  Output     Input  Output     Input  Output     Input  Output     Input  Output
 * 1      2:01       0      0:16       23     0:14       11     11:23      12     13:04
 * 46                01                59                08                49
*/

using System;

namespace Time_plus_15_Minutes
{
    class MainClass
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes == 60)
            {
                minutes = 0;
                hours += 1;

                if (hours == 24)
                {
                    hours = 0;
                }
            }
            else if (minutes > 60)
            {
                minutes = minutes - 60;
                hours += 1;

                if (hours == 24)
                {
                    hours = 0;
                }
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
