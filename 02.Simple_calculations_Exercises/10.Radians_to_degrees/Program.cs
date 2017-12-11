/*
 * 10. Radians to Degrees
 * 
 * Write a program that reads an angle in radians (rad) entered by the user and converts it into degrees (deg).
 * Look for an appropriate formula online. The number π in C # programs is available through Math.PI.
 * Round the result to the nearest integer using Math.Round ().
*/

using System;

namespace Radians_to_degrees
{
    class MainClass
    {
        public static void Main()
        {
            double radians = double.Parse(Console.ReadLine());

            double degrees = Math.Round(radians * (180 / Math.PI), 2);

            Console.WriteLine(degrees);
        }
    }
}
