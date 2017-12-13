/*
 * 10. Check Prime
 * 
 * Write a program that reads an integer n entered by the user and checks whether it is a
 * simple number (whether it is divided by itself and of 1). Print "Prime" or "Not prime".
*/

using System;

namespace Check_prime
{
    class MainClass
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool checker = true;

            if (number < 2)
            {
                checker = false;
            }
            else
            {
                for (long i = 1; i <= (long)Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        checker = false;
                        break;
                    }
                }
            }

            if (checker == true)
            {
                Console.WriteLine("Prime");
            }
            else if (checker == false)
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
