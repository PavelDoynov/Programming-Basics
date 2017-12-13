/*
 * 11. Fibonacci
 * 
 * Write a program that reads an integer n entered by the user and calculates the n Fibonacci number. 
 * The zero number of Fibonacci is 1, the first one is also 1, and each one is the sum of the previous two.
*/

using System;

namespace Fibonacci
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int fibonacciNumber = 0;

            int currentNumber = 1;
            int previousNumber = 0;

            if (number == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    fibonacciNumber = currentNumber + previousNumber;
                    previousNumber = currentNumber;
                    currentNumber = fibonacciNumber;

                }

                Console.WriteLine(fibonacciNumber);
            }
        }
    }
}
