/*
 * 14. Number Table
 * 
 * Write a program that reads an integer n entered by the user and prints a 
 * table (matrix) of numbers as in the example:
 * 
 * input   output
 *  4      1 2 3 4
 *         2 3 4 3
 *         3 4 3 2
 *         4 3 2 1
*/


using System;

namespace Number_table
{
    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                int left = row;
                int right = n - 1;
                for (int col = 1; col <= n; col++)
                {
                    if (left <= n)
                    {
                        Console.Write("{0} ", left);
                        left++;
                    }
                    else
                    {
                        Console.Write("{0} ", right);
                        right--;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
