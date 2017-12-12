/*
 * 09. House
 * 
 * Write a program that reads a number n (2 ≤ n ≤ 100) entered by the user and prints a house n x n.
 * Example:
 * 
 *  input   output        input   output
 *    5     --*--           6     --**--
 *          -***-                 -****-
 *          *****                 ******
 *          |***|                 |****|
 *          |***|                 |****|
 *                                |****|
*/

using System;

namespace House
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 2 || number <= 100)
            {
                if (number % 2 == 0)
                {
                    int count = (number / 2) - 1;
                    for (int i = 1; i <= number / 2; i++)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', count), new string('*', i * 2));
                        count -= 1;
                    }
                }
                else if (number % 2 != 0)
                {
                    int countForDash = (number / 2);
                    int countOfStars = 2;
                    for (int i = 0; i < (number / 2) + 1; i++)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', countForDash), 
                                          new string('*', (i * countOfStars) + 1));
                        countForDash -= 1;
                    }
                }

                for (int i = 0; i < number / 2; i++)
                {
                    Console.WriteLine("|{0}|", new string('*', number - 2));
                }
            }
        }
    }
}
