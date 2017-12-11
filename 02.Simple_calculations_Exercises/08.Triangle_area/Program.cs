/*
 * 08. Triangle area
 * 
 * Write a program that reads from the console side and the triangle height entered by the user, 
 * and calculates triangle area. Use the triangle area formula: area = a * h / 2. 
 * Round the result to 2 decimal places using "Math.Round (area, 2)".
*/

using System;

namespace Triangle_area
{
    class MainClass
    {
        public static void Main()
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double area = Math.Round(triangleSide * triangleHeight / 2, 2);

            Console.WriteLine($"Triangle area = {area}");
        }
    }
}
