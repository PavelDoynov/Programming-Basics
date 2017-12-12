/*
 * 02. Rectangle of N x N stars
 * 
 * Write a program that reads a positive integer "n" entered by the user and 
 * prints the console rectangle of n * n asterisks. 
 * Examples:
 * 
 *  input output       input  output
 *     2    **           3      ***
 *          **                  ***
 *                              ***
*/

using System;

namespace Rectangle_of_NxN_stars
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
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
