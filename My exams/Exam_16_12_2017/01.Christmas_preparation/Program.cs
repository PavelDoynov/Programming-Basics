/*
 * 01. Christmas preparation
 * 
 * Christmas is approaching, and Santa is not ready yet with the gifts. He has to order materials 
 * with which the dwarves can make Christmas presents. Every Christmas in the store where Santa is 
 * shopping, there is a reduction, which represents a certain percentage of the cost of the materials 
 * (the materials are wrapping paper in the form of rolls, cloth also in rolls, glue in liters). 
 * The console introduces the amount of rolls of paper , rolls of cloth, glue in liters and a percentage discount. 
 * How much money will Santa need to pay if the prices of the materials in the store are: 
 *   • Wrapping paper - 5.80 BGN (per roll) 
 *   • Cloth - 7.20 BGN (per roller) 
 *   • Glue - 1.20 BGN (per liter)
 * 
 * Input:
 * 4 numbers are read from the console: 
 *   • First row - number of rolls of wrapping paper. An integer in the range [0 ... 100] 
 *   • Second row - number of rolls of cloth. An integer in the range [0 ... 100] 
 *   • Third row - liter of glue. Real number in the range [0.00 ... 50.00] 
 *   • Fourth row - percentage decrease. An integer in the range [0 ... 100]
 * 
 * Output:
 * Print a real number on the console - How much money will Santa need to pay for the bill. 
 * The result is FORMAT to the third character after the decimal separator. (1.2457 -> 1.245).
 * 
 * Example:
 * Input    Output
 * 2        27.150
 * 3
 * 2.5
 * 25
*/

using System;

namespace Christmas_preparation
{
    class MainClass
    {
        public static void Main()
        {
            int paper = int.Parse(Console.ReadLine());
            int textile = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double paperPrice = 5.8;
            double textilePrice = 7.2;
            double gluePrice = 1.20;

            double totalPricePaper = paper * paperPrice;
            double totalPriceTextile = textile * textilePrice;
            double totalPriceGlue = glue * gluePrice;

            double totalPricePresents = (totalPriceGlue + totalPricePaper + totalPriceTextile) - 
                (((totalPriceGlue + totalPricePaper + totalPriceTextile) * discountPercentage) / 100);

            Console.WriteLine($"{totalPricePresents:f3}");


        }
    }
}
