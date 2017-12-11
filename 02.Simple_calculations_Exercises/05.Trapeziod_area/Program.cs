/*
 * 05. Trapeziod area
 * 
 * Write a program that reads from the console three numbers "b1", "b2" and "h"
 * entered by the user and calculates the trapeziod area of the trapezium with bases "b1" and "b2" and height "h".
 * The trapezoid area formula is (b1 + b2) * h / 2.
*/

using System;

namespace Trapeziod_area
{
    class MainClass
    {
        public static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (b1 + b2) * h / 2;

            Console.WriteLine($"Trapeziod area = {area}");
        }
    }
}
