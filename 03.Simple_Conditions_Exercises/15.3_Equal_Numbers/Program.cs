/*
 * 15. 3 Equal Numbers
 * 
 * Three equal numbers: enter 3 numbers and print whether they are the same (yes / no).
*/

using System;

namespace _Equal_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
