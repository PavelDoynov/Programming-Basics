/*
 * 03. Even or Odd
 * 
 * Write a program that reads an integer entered by the user and prints whether it is even or odd.
 * Examples:
 * Input   Output       Input    Output
 * 2       even         3        odd
*/


using System;

namespace Even_or_Odd
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("odd");
            }
        }
    }
}
