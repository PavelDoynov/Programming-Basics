/*
 * 07. 2D Recangle area
 * 
 * A rectangle is given with the coordinates of two of its opposite angles (x1, y1) - (x2, y2). 
 * Calculate its area and perimeter. The input is entered by the user. 
 * The numbers x1, y1, x2 and y2 are given in one order. 
 * The output is typed to the console and must contain two rows with one number each - rectangle area and perimeter.
*/

using System;

namespace D_Rectangle_area
{
    class MainClass
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);

            double area = sideA * sideB;
            double perimeter = 2 * (sideA + sideB);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
