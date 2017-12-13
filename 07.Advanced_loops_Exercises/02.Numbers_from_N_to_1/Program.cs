/*
 * 02. Numbers form N to 1
 * 
 * Write a program that reads a positive integer n entered by the user and 
 * prints the numbers from n to 1 in reverse order (from the largest to the smallest).
*/

using System;

namespace Numbers_from_N_to_1
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
