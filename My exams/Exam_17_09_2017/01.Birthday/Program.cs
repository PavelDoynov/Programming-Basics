/*
 * 01. Birthday
 * 
 * For his birthday, Lyubomir had an aquarium with the shape of a parallelepiped. 
 * Initially we read from the console of individual rows its dimensions - length, width and height in centimeters. 
 * It should be calculated how many liters of water the aquarium will collect if it 
 * is known that a certain percentage of its capacity is occupied by sand, plants, 
 * heater and pump. One liter of water equals one cubic decimeter / liter = 1 dm3 /.
 * Write a program that calculates the liters of water needed to fill the tank.
 * 
 * Input:
 * From the console are read 4 lines: 
 *   1. Length in cm - integer in the range [10 ... 500]; 
 *   2. Width in cm - integer in the range [10 ... 300]; 
 *   3. Height in cm - integer in the range [10 ... 200]; 
 *   4. Percentage - real number in the range [0.000 ... 100.000];
 * 
 * Output:
 * To print a number on the console: 
 *   - the water that will collect the aquarium formatted to the third decimal place.
*/

using System;

namespace Birthday
{
    class MainClass
    {
        public static void Main()
        {
            int lendth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double valueOfAquarium = (lendth * width * height) * 0.001;
            double fillPercentage = percentage * 0.01;

            Console.WriteLine($"{valueOfAquarium * (1 - fillPercentage):f3}");

        }
    }
}
