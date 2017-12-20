/*
 * 05. Sheriff
 * 
 * Baba Vera likes to sew a carriage. Write a program that reads an integer n from 
 * the console and draws a embroidery with a width of 3 * n columns and 2 * n + 8 rows, as in the examples below.
 * 
 * Input:
 * The input is a whole odd number n in the range [1 ... 100].
 * 
 * Output:
 * Print 2 * n + 8 text lines depicting the embroidery on the console, just as in the examples.
 * 
 * Example:
 * Input    Output     
 * 3        ....x.... 
 *          .../x\... 
 *          ...x|x... 
 *          .xxx|xxx. 
 *          xxxx|xxxx 
 *          .xxx|xxx. 
 *          .../x\... 
 *          ...\x/... 
 *          .xxx|xxx. 
 *          xxxx|xxxx 
 *          .xxx|xxx. 
 *          ...x|x... 
 *          ...\x/... 
 *          ....x....
*/

using System;

namespace Sheriff
{
    class MainClass
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', (input * 3 - 1) / 2), "x");
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (input * 3 - 3) / 2), "/", "x", "\\");
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (input * 3 - 3) / 2), "x", "|");

            int dots = ((input * 3) - (input * 2 + 1)) / 2;
            int currentX = input;

            for (int i = 0; i <= input / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', currentX));
                currentX += 1;
                dots -= 1;
            }

            currentX -= 1;
            dots += 1;

            for (int i = input / 2; i > 0; i--)
            {
                currentX -= 1;
                dots += 1;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', currentX));
            }

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (input * 3 - 3) / 2), "/", "x", "\\");
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (input * 3 - 3) / 2), "\\", "x", "/");

            for (int i = 0; i <= input / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', currentX));
                currentX += 1;
                dots -= 1;
            }

            currentX -= 1;
            dots += 1;

            for (int i = input / 2; i > 0; i--)
            {
                currentX -= 1;
                dots += 1;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', currentX));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (input * 3 - 3) / 2), "x", "|");
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (input * 3 - 3) / 2), "\\", "x", "/");
            Console.WriteLine("{0}{1}{0}", new string('.', (input * 3 - 1) / 2), "x");
        }
    }
}
