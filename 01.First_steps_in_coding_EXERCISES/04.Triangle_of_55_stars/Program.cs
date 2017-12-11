/* 
 * 04. Triangle of 55 stars
 * 
 * Type a C# console program that prints a triangle of 55 asterisks located in 10 rows.
 */

using System;

namespace Triangle_of_55_stars
{
    class MainClass
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
