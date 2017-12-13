/*
 * 04. Even powers of 2
 * 
 * Write a program that reads a number n entered by the user and prints the even degrees 
 * of 2 ≤ 2n: 20, 22, 24, 28, ..., 2n.
*/

using System;

namespace Even_powers_of_2
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(result);

                    result *= 4; 
                }
            }
        }
    }
}
