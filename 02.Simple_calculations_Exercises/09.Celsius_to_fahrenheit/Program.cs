/*
 * 09. Celsius to fahrenheit
 * 
 * Write a program that reads Celsius degrees (° C) entered by the user and converts 
 * them to degrees Fahrenheit (° F). 
 * Look for an appropriate formula on the Internet to make the calculations.
*/

using System;

namespace Celsius_to_fahrenheit
{
    class MainClass
    {
        public static void Main()
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(fahrenheit);
        }
    }
}
