/*
 * 02. Numbers ending in 7
 * 
 * Write a program that prints the numbers in the range [1 ... 1000], ending at 7.
*/

using System;

namespace Numbers_ending_in_7
{
    class MainClass
    {
        public static void Main()
        {
            for (int i = 7; i <= 1000; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}

/* Or you can use this:
 * for (int i = 1; i <= 1000; i++)
 *         {
 *              if (i % 10 ==7 )
 *              {
 *                  Console.WriteLine(i);
 *              }
 *          }
*/