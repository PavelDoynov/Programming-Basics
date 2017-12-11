/*
 * 06. Square of stars
 * 
 * Write a C# console program that reads from the console a positive integer N entered by the user 
 * and prints a console square of N asterisks as in the examples below:
 * 
 *  3    *** 
 *       * *
 *       ***
 * 
 *  4    ****
 *       *  *
 *       *  *
 *       ****
 * 
 *  5    *****
 *       *   *
 *       *   *
 *       *   *
 *       *****
*/

using System;

namespace Square_of_stars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', n - 2));
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
