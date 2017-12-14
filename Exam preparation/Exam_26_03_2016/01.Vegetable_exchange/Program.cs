/*
 * 01. Vegetable Exchange
 * 
 * Gardener sold the crop from his garden to the vegetable market. 
 * Sell vegetables for N levs per kilogram and fruits for M levs per kilogram. 
 * Write a program to calculate the yields of the harvest in euro (assuming one euro is 1.94lv).
 * 
 * Input:
 * The console reads 4 numbers, one per line:
 * • First line - Price per kilogram of vegetables - floating point
 * • Second row - Price per kilogram of fruit - floating-point number
 * • Third row - Total kilo of vegetables - whole number
 * • Fourth row - Total kilograms of fruit - an integer
 * 
 * Output:
 * Print a floating point number on the console: All fruit and vegetables in EUR.
*/

using System;

namespace Vegetable_exchange
{
    class MainClass
    {
        public static void Main()
        {
            double ppkVegetable = double.Parse(Console.ReadLine());
            double ppkFruit = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double totalVegetablesPrice = ppkVegetable * vegetablesKg;
            double totalFruitsPrice = ppkFruit * fruitsKg;

            double totalSumBGN = totalFruitsPrice + totalVegetablesPrice;
            double totalSumEUR = totalSumBGN / 1.94;

            Console.WriteLine(totalSumEUR);

        }
    }
}
