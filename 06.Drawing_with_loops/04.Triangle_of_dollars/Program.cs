/*
 * 04. Triangle of dollars
 * 
 * Write a program that reads a number n entered by the user and 
 * prints a triangle of dollars as in the example:
 * 
 *  input   output
 *    4      $
 *           $ $
 *           $ $ $
 *           $ $ $ $
*/

using System;

namespace Triangle_of_dollars
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}
