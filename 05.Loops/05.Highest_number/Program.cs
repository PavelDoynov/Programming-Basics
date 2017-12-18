/*
 * 05. Highest Number
 * 
 * Write a program that reads n number of integers (n> 0) entered by the user and finds the largest of them. 
 * First, the number of ns is entered, and then the n numbers themselves, one per line.
 */

using System;

namespace Highest_number
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;

            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
