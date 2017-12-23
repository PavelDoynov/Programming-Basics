/*
 * 12. Speed Info
 * 
 * Write a program that reads a speed (decimal number) entered by the user and prints speed information. 
 * 
 * At speeds of up to 10 (inclusive), print "slow".
 * At speeds over 10 and up to 50, print "average". 
 * At speeds over 50 and up to 150, print "fast". 
 * At speed above 150 and up to 1000, print "ultra fast". 
 * At higher speed, print "extremely fast".
*/

using System;

namespace Speed_Info
{
    class MainClass
    {
        public static void Main()
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10.00)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10.00 && speed <= 50.00)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50.00 && speed <= 150.00)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150.00 && speed <= 1000.00)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000.00)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
