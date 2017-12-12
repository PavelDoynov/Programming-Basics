/*
 * 05. Draw fort
 * 
 * Write a program that reads from the console an integer "n" and draws a fortress 
 * with a width of 2 * n columns and a height "n" lines as in the examples below. 
 * The left and right columns in the interior are wide n / 2.
 * 
 *  input  output       input     output        input         output
 *    4   /^^\/^^\        5     /^^\__/^^\        8      /^^^^\____/^^^^\
 *        |      |              |        |               |              |
 *        |      |              |        |               |              |
 *        \__/\__/              |   __   |               |              |   
 *                              \__/  \__/               |              |
 *                                                       |     ____     |
 *                                                       \____/    \____/
 * 
 * Input:
 * The input is an integer n in the range [3 ... 1000].
*/

using System;

namespace Draw_fort
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 3 && number <= 1000)
            {
                int topMiddlePart = 0;
                
                if (number % 2 == 0)
                {
                    topMiddlePart = number * 2 - (number + 4);
                }
                else if (number % 2 != 0)
                {
                    topMiddlePart = (number * 2 - (number + 4)) + 1;
                }

                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', number / 2), 
                                  new string('_', topMiddlePart));

                for (int i = 1; i <= number - 3; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', number * 2 - 2));
                }

                Console.WriteLine("|{0} {1} {0}|", new string(' ', number / 2),
                                  new string('_', topMiddlePart));
                
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', number / 2),
                                  new string(' ', topMiddlePart));
            }
        }
    }
}
