/*
 * 11. Enter Even Number
 * 
 * Write a program that reads an even number entered by the user. If the user enters 
 * the wrong number (odd number or string that is not an integer), 
 * an error message must be issued and entered again.
*/

using System;

namespace Enter_even_number
{
    class MainClass
    {
        public static void Main()
        {
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int currentNumber = int.Parse(Console.ReadLine());

                    if (currentNumber % 2 == 0)
                    {
                        number = currentNumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
