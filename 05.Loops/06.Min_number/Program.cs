/*
 * 06. Min Number
 * 
 * Write a program that reads n number of integers (n> 0) entered by the user and finds 
 * at least one of them. First, the number of ns is entered, and then the n numbers themselves, one per line.
*/

using System;

namespace Min_number
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
