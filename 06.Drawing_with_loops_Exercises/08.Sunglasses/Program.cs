/*
 * 08. Sunglasses
 * 
 * Write a program that reads an integer n (3 ≤ n ≤ 100) entered by the 
 * user and prints sunglasses of 5 * n x n as in the example:
 * 
 * input         output
 *   3     ******   ******
 *         *////*|||*////*
 /*        ******   ******
 *
 *   4     ********    ********
 *         *//////*||||*//////*
 /*        *//////*    *//////*
 /*        ********    ********
*/

using System;

namespace Sunglasses
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 3 && number <= 100)
            {

                Console.WriteLine("{0}{1}{0}", new string('*', number * 2), new string(' ', number));

                for (int i = 0; i < number - 2; i++)
                {
                    if (i == (number - 2) / 2 && number % 2 != 0)
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', number * 2 - 2), new string('|', number));
                    }
                    else if (i == ((number - 2) / 2) - 1 && number % 2 == 0)
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', number * 2 - 2), new string('|', number));
                    }
                    else
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', number * 2 - 2), new string(' ', number));
                    }
                }

                Console.WriteLine("{0}{1}{0}", new string('*', number * 2), new string(' ', number));
            }
        }
    }
}
