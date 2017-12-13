/*
 * 05. Sequence 2k + 1
 * 
 * Write a program that reads a n number given by the user and prints all numbers ≤ n of the row: 
 * 1, 3, 7, 15, 31, .... 
 * Each subsequent number is calculated as the previous number * 2 + 1.
*/

using System;

namespace Sequence_2k_plus_1
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = 0;
            int resultNumber = 0;

            for (int i = 1; i <= 100000; i++)
            {
                currentNumber = resultNumber * 2 + 1;

                if (currentNumber >= resultNumber)
                {
                    resultNumber = currentNumber;
                }
                if (resultNumber > number)
                {
                    break;
                }

                Console.WriteLine(resultNumber);
            }
        }
    }
}
