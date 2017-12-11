/*
 * 05. Rectangle area
 * 
 * Write a C # program that reads from the console the two numbers "a" and "b" entered by the user, 
 * calculates and prints the rectangle area of a rectangle with sides "a" and "b". 
 * 
 * Example Input and Output:
 * 
 *  a    b   area
 *  2   7    14
 *  7   8    56
 *  12  5    60
 */

using System;

namespace Rectangle_area
{
    class MainClass
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = a * b;

            Console.WriteLine(sum);
        }
    }
}
