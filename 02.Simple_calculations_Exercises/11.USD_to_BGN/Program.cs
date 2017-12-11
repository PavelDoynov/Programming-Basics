/*
 * 11.USD to BGN
 * 
 * Write down a program to convert US Dollars (USD) into Bulgarian Leva (BGN). 
 * Round the result to 2 digits after the decimal point. 
 * Use a fixed exchange rate between USD and BGN: 1 USD = 1.79549 BGN.
*/

using System;

namespace USD_to_BGN
{
    class MainClass
    {
        public static void Main()
        {
            decimal USD = decimal.Parse(Console.ReadLine());

            decimal convertToBGN = USD * 1.79549m;

            Console.WriteLine(Math.Round(convertToBGN, 2));
        }
    }
}
