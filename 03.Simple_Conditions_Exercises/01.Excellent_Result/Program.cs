/*
 * 01. Excellent Result
 * 
 * The first task of this topic is to write a console program that reads a user-defined estimate 
 * (decimal number) and prints "Excellent!" If the score is 5.50 or higher.
 */

using System;

namespace Excellent_Result
{
    class MainClass
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
