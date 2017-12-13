/*
 * 03. Square of stars
 * 
 * Write a program that reads a number n entered by the user and draws a square of n * n asterisks.
 * The difference with the previous task is that there is a space between each two asterisks. 
 * Examples:
 * 
 *   input   output
 *     3     * * *
 *           * * *
 *           * * *
*/

using System;

namespace Square_of_stars
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
