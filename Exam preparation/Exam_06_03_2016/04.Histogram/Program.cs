/*
 * 04. Histogram
 * 
 * There are n integers in the range [1 ... 1000]. Of these, some percentages of p1 
 * are less than 200, another p2 is from 200 to 399, another p3 is from 400 to 599, 
 * another p4 is from 600 to 799, and the other p5 percent is from 800 upwards. 
 * Write a program that calculates and prints the percentages p1, p2, p3, p4 and p5.
 * 
 * Example: 
 * we have n = 20 numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2 600, 200, 800, 799, 
 * distribution and visualization:
 * 
 *    Range      Numbers in range                                   Numbers of integers         Percentage
 *  < 200        53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65            12            p1 = 12 / 20 * 100 = 60.00%
 *  200 … 399    250, 200                                                    2            p2 = 2 / 20 * 100 = 10.00%
 *  400 … 599    450                                                         1            p3 = 1 / 20 * 100 = 5.00%
 *  600 … 799    680, 600, 799                                               3            p4 = 3 / 20 * 100 = 15.00%
 *  ≥ 800        920, 800                                                    2            p5 = 2 / 20 * 100 = 10.00%
 * 
 * Input:
 * The first line of the input is the integer n (1 ≤ n ≤ 1000) - number of integers. 
 * The next n row is one integer in the range [1 ... 1000] - the numbers on which to calculate the histogram.
 * 
 * Output:
 * Print a histogram - 5 rows, each containing a number between 0% and 100%, 
 * two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.
*/

using System;

namespace Histogram
{
    class MainClass
    {
        public static void Main()
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());

            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;
            double countP4 = 0;
            double countP5 = 0;

            for (int i = 1; i <= numberOfIntegers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    countP1 += 1;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    countP2 += 1;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    countP3 += 1;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    countP4 += 1;
                }
                else if (numbers >= 800)
                {
                    countP5 += 1;
                }
            }

            Console.WriteLine("{0:f2}%", (countP1 / numberOfIntegers) * 100);
            Console.WriteLine("{0:f2}%", (countP2 / numberOfIntegers) * 100);
            Console.WriteLine("{0:f2}%", (countP3 / numberOfIntegers) * 100);
            Console.WriteLine("{0:f2}%", (countP4 / numberOfIntegers) * 100);
            Console.WriteLine("{0:f2}%", (countP5 / numberOfIntegers) * 100);
        }
    }
}
