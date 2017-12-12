/*
 * 06. Rhombus of stars
 * 
 * Write a program that reads a positive integer "n", entered by the user, 
 * and prints a diamond-sized nylon as in the example below:
 * 
 *  input    output
 *    3        *
 *            * *
 *           * * *
 *            * *
 *             *
*/

using System;

namespace Rhombus_of_stars
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string star = "* ";

            for (int i = 1; i <= number; i++)
            {
                
                Console.WriteLine("{0}{1}{2}", new string(' ', number - i), star, new string(' ', i));

                star += "* ";
            }

            star = "* ";

            for (int i = number - 1; i >= 1; i--)
            {
                Console.Write("{0}", new string(' ', number - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(star);
                }

                Console.Write("{0}", new string(' ', number - i));

                Console.WriteLine();
            }
        }
    }
}
