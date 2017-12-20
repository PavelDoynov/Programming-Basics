/*
 * 07. Left and Right Sum
 * 
 * Write a program that reads 2 * n of whole numbers given by the user and checks 
 * if the sum of the first n numbers (left amount) is equal to the sum of the second n numbers (right amount).
 * In the case of a tie, "Yes" + the amount; otherwise it prints "No" + the difference. 
 * The difference is calculated as a positive integer (in absolute terms).
*/

using System;

namespace Left_and_right_sum
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int leftAmount = 0;
            int rightAmount = 0;

            for (int i = 1; i <= numbers * 2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i <= numbers)
                {
                    leftAmount += currentNumber;
                }
                else
                {
                    rightAmount += currentNumber;
                }
            }

            if (leftAmount == rightAmount)
            {
                Console.WriteLine($"Yes, sum = {leftAmount}");
            }
            else
            {
                int sumDifference = Math.Abs(leftAmount - rightAmount);

                Console.WriteLine($"No, diff = {sumDifference}");
            }
        }
    }
}
