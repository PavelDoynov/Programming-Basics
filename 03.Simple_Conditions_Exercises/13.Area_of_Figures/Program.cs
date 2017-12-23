/*
 * 13. Area of Figures
 * 
 * Write a program in which the user introduces the type and dimensions of a geometric figure and calculates its face.
 * The figures are four types: square, rectangle, circle, and triangle.
 * On the first row of the input the shape of the figure (square, rectangle, circle or triangle) is read. 
 * If the figure is a square, the next row reads one number - its length. 
 * If the figure is a rectangle, the next two lines read two numbers - the lengths of its sides.
 * If the figure is a circle, the next row reads one number - the radius of the circle. 
 * If the figure is a triangle, the next two lines read two numbers - the length of its side and 
 * the length of the height to it. Round the result to 3 digits after the decimal point.
*/

using System;

namespace Area_of_Figures
{
    class MainClass
    {
        public static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = Math.Pow(side, 2);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = width * height;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double triangleBase = double.Parse(Console.ReadLine());
                double verticalHeight = double.Parse(Console.ReadLine());
                double area = verticalHeight * triangleBase * 0.5;
                Console.WriteLine($"{area:f3}");
            } 
        }
    }
}
