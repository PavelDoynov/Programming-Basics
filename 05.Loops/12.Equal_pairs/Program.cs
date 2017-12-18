/*
 * 12. Equal Pairs
 * 
 * Given are 2 * n  numbers. The first and the second form a pair, the third and the fourth also, etc. 
 * Each pair has a value - the sum of its numbers. Write a program that checks whether all pairs 
 * have the same value or prints the maximum difference between two consecutive pairs. 
 * If all pairs have the same value, print "Yes, value = {Value}" + the value. 
 * Otherwise, print "No, maxdiff = {Difference}" + the maximum difference.
 * 
*/

using System;

namespace Equal_pairs
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int currentSumOfNumbers = 0;
            int sumOfNumbers = 0;
            int maxDiff = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int currentNumberOne = int.Parse(Console.ReadLine());
                int currentNumberTwo = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    currentSumOfNumbers = currentNumberOne + currentNumberTwo;
                    sumOfNumbers = currentSumOfNumbers;
                }
                else
                {
                    currentSumOfNumbers = currentNumberOne + currentNumberTwo;

                    if (sumOfNumbers == currentSumOfNumbers)
                    {
                        maxDiff += 0;
                    }
                    else
                    {
                        maxDiff = Math.Abs(sumOfNumbers - currentSumOfNumbers);

                        sumOfNumbers = currentSumOfNumbers;
                    }
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sumOfNumbers);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
