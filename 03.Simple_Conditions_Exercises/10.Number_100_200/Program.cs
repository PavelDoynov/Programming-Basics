/*
 * 10. Number 100...200
 * 
 * Write a program that reads an integer entered by the user and checks if it is below 100, between 100 and 200 or over 200.
 * Print messages as in the examples below:
 * 
 * Input  Output            Input  Output                   Input  Output
 * 95     Less than 100     120    Between 100 and 200      210    Greater than 200
*/


using System;

namespace Number_100_200
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
