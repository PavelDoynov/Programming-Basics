/*
 * 03. Powers of two
 * 
 * Write a program that reads from the console an integer n entered by the user and prints the numbers from 1 to 2n.
*/

using System;

namespace Powers_of_two
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i <= number; i++)
            {
                if (i >= 1)
                {
                    result *= 2;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}
