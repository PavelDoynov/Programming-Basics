/*
 * 02.Excellent or Not
 * 
 * The next task of this topic is to write a console program that reads a user-defined 
 * estimate (decimal number) and prints "Excellent!" If the score is 5.50 or higher or "Not excellent." Otherwise.
*/

using System;

namespace Excellent_or_Not
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
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
