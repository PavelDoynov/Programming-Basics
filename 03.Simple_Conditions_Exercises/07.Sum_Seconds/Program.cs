/*
 * 07. Sum Seconds
 * 
 * Three athletes finish for some seconds (between 1 and 50). Write a program that reads the times of 
 * the contestants entered by the user and calculates their cumulative time in minutes: seconds. 
 * Take seconds to lead zero (2 → "02", 7 → "07", 35 → 35). 
 * 
 * Examples:
 * Input  Output       Input  Output
 * 35     2:04         50     2:29
 * 45                  50
 * 44                  49
*/

using System;

namespace Sum_Seconds
{
    class MainClass
    {
        public static void Main()
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());

            int sumSeconds = seconds1 + seconds2 + seconds3;

            int minutes = sumSeconds / 60;
            int newSeconds = sumSeconds - (minutes * 60);

            if (minutes == 0)
            {
                Console.WriteLine($"0:{newSeconds:D2}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{newSeconds:D2}");
            }
        }
    }
}
