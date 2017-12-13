/*
 * 01. Rectangle of 10 x 10 stars
 * 
 * Write a program that draws a 10 x 10-pointed rectangle on the console:
 * 
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
 *  **********
*/

using System;

namespace Rectangle_of_10x10_stars
{
    class MainClass
    {
        public static void Main()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }
    }
}
