/*
 * 06. Number in range [1 ... 100]
 * 
 * Write a program that reads a positive integer n in the range [1 ... 100] entered by the user. 
 * When entering a number outside the specified range, an error message is printed and the user 
 * is prompted to enter a new number.
*/

using System;

namespace Number_in_range_from_1_to_100
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");

                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
