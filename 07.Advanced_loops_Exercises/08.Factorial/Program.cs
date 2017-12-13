/*
 * 08. Factorial
 * 
 * Write a program that reads an integer n (1 ≤ n ≤ 12) entered by the user and
 * calculates and prints n! = 1 * 2 * ... * n (n factorial).
*/

using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
