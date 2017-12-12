/*
 * 05. Square frame
 * 
 * Write a program that reads a positive integer "n", entered by the user, 
 * and draws on the console a square frame of n * n as in the examples below:
 * 
 *  input   output
 *    5    + - - - +
 *         | - - - |
 *         | - - - |
 *         | - - - |
 *         + - - - +
 */

using System;

namespace Square_frame
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string topRow = "+ ";
            string middlePart = null;
            string topRowLast = "+";

            for (int i = 1; i <= number-2; i++)
            {
                middlePart += "- ";
            }

            topRow = topRow + middlePart + topRowLast;

            Console.WriteLine(topRow);


            for (int i = 1; i <= number - 2; i++)
            {
                Console.WriteLine($"| {middlePart}|");
            }

            Console.WriteLine(topRow);
        }
    }
}
