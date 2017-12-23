/*
 * 04. Greater Number
 * 
 * Write a program that reads two integers entered by the user and prints the larger one. 
 * Examples:
 * Input Output       Input Output       Input Output       Input Output
 * 5     5            3     5            10    10           -5    5 
 * 3                  5                  10                 5
*/


using System;

namespace Greater_Number
{
    class MainClass
    {
        public static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                Console.WriteLine(numberA);
            }
            else if (numberA < numberB)
            {
                Console.WriteLine(numberB);
            }
            else
            {
                Console.WriteLine(numberA);
            }
        }
    }
}
