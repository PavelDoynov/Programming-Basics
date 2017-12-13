/*
 * 01. Numbers from 1 to N with step 3
 * 
 * Write a program that reads a number n entered by the user and prints the numbers from 1 to n through 3 (in step 3).
*/

using System;

namespace Numbers_from_1_to_N_with_step_3
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
