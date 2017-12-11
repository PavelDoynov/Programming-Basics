/*  
 * 01. Square area
 * 
 * Write a console program that reads an integer "a" entered by the user, 
 * and calculates the square area of a square with side "a".
*/

using System;

namespace Square_area
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("a = ");

            int a = int.Parse(Console.ReadLine());

            int area = a * a;

            Console.Write($"Square = {area}");
        }
    }
}
