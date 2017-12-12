/*
 * 10. Diamond
 * 
 * Write a program that reads an integer "n" (1 ≤ n ≤ 100) entered by the user and 
 * prints a diamond of n size as in the examples below:
 * 
 * input   output       input   output       input   output       input   output       input   output
 *   1       *            2        **           3     -*-           4      -**-          5     --*--  
 *                                                    *-*                  *--*                -*-*-
 *                                                    -*-                  -**-                *---*
 *                                                                                             -*-*-
 *                                                                                             --*--
*/

using System;

namespace Diamond
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                if (number == 1)
                {
                    Console.WriteLine("*");
                }
                else if (number == 2)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("{0}*{0}", new string('-', number / 2));

                        int countMiddlePart = 1;
                        int countEndPart = 1;

                        for (int i = 1; i < (number / 2); i++)
                        {
                            Console.WriteLine("{0}*{1}*{0}", new string('-', number / 2 - countEndPart),
                                              new string('-', countMiddlePart));
                            countMiddlePart += 2;
                            countEndPart += 1;
                        }

                        Console.WriteLine("*{0}*", new string('-', number - 2));

                        for (int i = number / 2; i > 1; i--)
                        {
                            countMiddlePart -= 2;
                            countEndPart -= 1;

                            Console.WriteLine("{0}*{1}*{0}", new string('-', number / 2 - countEndPart), 
                                              new string('-', countMiddlePart));
                        }

                        Console.WriteLine("{0}*{0}", new string('-', number / 2));
                    }
                    else if (number % 2 == 0)
                    {
                        Console.WriteLine("{0}**{0}", new string('-', (number / 2) - 1));

                        int countMiddlePart = 1;
                        int countEndPart = 1;

                        for (int i = 1; i < (number / 2); i++)
                        {
                            Console.WriteLine("{0}*{1}*{0}", new string('-', (number / 2 - countEndPart) - 1),
                                              new string('-', countMiddlePart + 1));
                            countMiddlePart += 2;
                            countEndPart += 1;
                        }

                        for (int i = number / 2 - 1; i > 1; i--)
                        {
                            countMiddlePart -= 2;
                            countEndPart -= 1;

                            Console.WriteLine("{0}*{1}*{0}", new string('-', number / 2 - countEndPart),
                                              new string('-', countMiddlePart - 1));
                        }

                        Console.WriteLine("{0}**{0}", new string('-', (number / 2) - 1));
                    }
                }
            }
        }
    }
}
