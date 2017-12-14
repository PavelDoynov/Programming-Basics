/*
 * 05. Butterfly
 * 
 * Write a program that reads from the console an integer n and 
 * draws a butterfly with a width of 2 * n - 1 columns and a height of 2 * (n - 2) + 1 
 * rows as in the examples below. Its left and right sides are wide n - 1.
 * 
 * Input:
 * The input is an integer n in the range [3 ... 1000].
 * 
 * Output:
 * Print the console 2 * (n - 2) + 1 text lines depicting the butterfly, just as in the examples.
*/



using System;

namespace Butterfly
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', number - 2));
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', number - 2));
                }
            }

            Console.WriteLine("{0}@", new string(' ', number - 1));

            for (int i = 1; i <= number - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', number - 2));
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', number - 2));
                }
            }
        }
    }
}
