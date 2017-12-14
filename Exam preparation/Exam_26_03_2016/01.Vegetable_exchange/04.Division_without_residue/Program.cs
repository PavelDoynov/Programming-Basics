/*
 * 04. Division Without Residue
 * 
 * There are n integers in the range [1 ... 1000]. Of these, a percentage of 
 * p1 is divisible without residue at 2, 
 * another percentage p2 is divisible without residue at 3, 
 * another percentage p3 is divisible without a remainder of 4. 
 * Write a program that calculates and prints the percentages p1, p2 and p3.
 * 
 * Example: 
 * We have n = 10 numbers: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. 
 * We get the following distribution and visualization:
 *   Partition without      Numbers in range:                      Number of integers:    Percent:
 *   residue of: 
 *         2                680, 2, 600, 200, 800, 46, 128                  7              p1 = 7 / 10 * 100 = 70.00%
 *         3                600                                             1              p2 = 1 / 10 * 100 = 10.00%
 *         4                680, 600, 200, 800, 128                         5              p3 = 5 / 10 * 100 = 50.00%
 * 
 * Input:
 * The first line of the input is the integer n (1 ≤ n ≤ 1000) - number of integers. 
 * The next n row is one integer in the range [1 ... 1000] - the numbers to be checked how divided they are.
 * 
 * Output:
 * Print 3 rows, each containing a percentage between 0% and 100%, 
 * two digits after the decimal point, for example 25.00%, 66.67%, 57.14%.
 * • On the first line - the percentage of the numbers divided by 2
 * • On the second line - the percentage of the numbers divided by 3
 * • On the third line - the percentage of the numbers divided by 4
*/

using System;

namespace Division_without_residue
{
    class MainClass
    {
        public static void Main()
        {
            int numberOfInt = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;

            for (int i = 0; i < numberOfInt; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countP1 += 1;
                }
                if (number % 3 == 0)
                {
                    countP2 += 1;
                }
                if (number % 4 == 0)
                {
                    countP3 += 1;
                }
            }

            double percentageOfTwo = (double)countP1 / numberOfInt * 100;
            double percentageOfThree = (double)countP2 / numberOfInt * 100;
            double percentageOfFour = (double)countP3 / numberOfInt * 100;

            Console.WriteLine($"{percentageOfTwo:f2}%");
            Console.WriteLine($"{percentageOfThree:f2}%");
            Console.WriteLine($"{percentageOfFour:f2}%");
        }
    }
}
