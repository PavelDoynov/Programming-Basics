/*
 * 07. Christmas tree
 * 
 * Write a program that reads the number n (1 ≤ n ≤ 100) entered by the user and 
 * prints a n-size Christmas tree as in the example below:
 * 
 * input    output
 *   4        |
 *          * | *
 *         ** | **
 *        *** | ***
 *       **** | ****
*/

using System;

namespace Christmas_tree
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("{0}{1} {2} {1}{0}", new string(' ', number - i),
                                  new string('*', i), "|");
            }
        }
    }
}
