/*
 * 04. Sum Numbers
 * 
 * Write a program that reads a number of integer numbers entered by the user and sums them.
 * • The number of n integers is entered from the first line of the input.
 * • Entering an integer from the next n row.
 * The program should read the numbers, sum them up and print the amount.
*/

using System;

namespace Sum_numbers
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
