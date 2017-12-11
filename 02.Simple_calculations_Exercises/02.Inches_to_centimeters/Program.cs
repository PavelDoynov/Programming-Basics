/* 
 * 02. Inches to centimeters
 * 
 * Write a program that reads a console number (not necessarily a integer) entered by the 
 * user and converts the number from inches into centimeters. 
 * For this purpose, it multiplies the inches by 2.54 (because 1 inch = 2.54 centimeters).
*/

using System;

namespace Inches_to_centimeters
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("inches = ");

            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;

            Console.WriteLine($"centimeters = {centimeters}");
        }
    }
}
