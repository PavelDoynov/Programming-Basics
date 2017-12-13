/*
 * 09. Sum Digits
 * 
 * Write a program that reads an integer num, entered by the user, and prints the sum of its digits.
 */

using System;

namespace Sum_digits
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sumDigit = 0;

            while (number != 0)
            {
                sumDigit += number % 10;

                number = number / 10;

            }

            Console.WriteLine(sumDigit);
        }
    }
}
