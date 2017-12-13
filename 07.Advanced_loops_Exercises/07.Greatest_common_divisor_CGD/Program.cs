/*
 * 07. Greatest common divisor GCD
 * 
 * Write a program that reads two positive integers a and b entered by the user and 
 * calculates and prints their largest total divisor (NOD).
 * 
 * Implement the Euclid algorithm
 */

using System;

namespace Greatest_common_divisor_CGD
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int gcd = 0;
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);

            while (a % b != 0)
            {
                    int c = a % b;
                    a = b;
                    b = c;
            }

            gcd = b;

            Console.WriteLine(gcd);
        }
    }
}
