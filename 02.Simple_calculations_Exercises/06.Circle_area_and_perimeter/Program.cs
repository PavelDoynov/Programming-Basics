/*
 * 06. Circle area and perimeter
 * 
 * Write a program that reads from the console the number "r" entered by the user and 
 * calculates and prints the circle area and perimeter of a circle / circle with a radius "r".
*/

using System;

namespace Circle_area_and_perimeter
{
    class MainClass
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
