/*
 * 13. Number Pyramid
 * 
 * Write a program that reads an integer n entered by the user and prints the pyramid of numbers as in the examples:
 * 
 * input  output     input   output
 *  7     1           10     1
 *        2 3                2 3
 *        4 5 6              4 5 6
 *        7                  7 8 9 10
*/


using System;

namespace Number_pyramid
{
    class MainClass
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int number = 0;
            bool checker = false;

            for (int i = 1; i <= input ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (number == input)
                    {
                        checker = true;
                        break;
                    }

                    number += 1;

                    Console.Write(number + " ");

                }

                if (checker == true)
                {
                   break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
