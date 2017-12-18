/*
 * 08. Odd Even Sum
 * 
 * Write a program that reads an integer number of nodes submitted by the user and checks if 
 * the sum of the even number is equal to the sum of the odd number numbers. 
 * In the case of a draw, "Yes" + the amount; otherwise you can print the "No" + difference. 
 * The difference is calculated in absolute terms.
*/

using System;

namespace Odd_even_sum
{
    class MainClass
    {
        public static void Main()
        {

            int numbers = int.Parse(Console.ReadLine());

            int evenNumbers = 0;
            int oddNumbers = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumbers += number;
                }
                else
                {
                    oddNumbers += number;
                }
            }

            if (evenNumbers == oddNumbers)
            {
                Console.WriteLine($"Yes Sum = {evenNumbers}");
            }
            else
            {
                int difference = Math.Abs(evenNumbers - oddNumbers);
                Console.WriteLine($"No Diff = {difference}");
            }
        }
    }
}
