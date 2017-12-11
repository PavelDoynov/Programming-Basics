/*
 * 12. Curreny converter
 * 
 * Write a program for converting money from one currency to another. 
 * The following currencies need to be maintained: BGN, USD, EUR, GBP. Use the following fixed exchange rates:
 * 
 *   Currency      USD      EUR      GBP
 *    1 BGN      1.79549  1.95583  2.53405
 * 
 * The input is a conversion amount, an input currency, a source currency entered by the user.
 * The output is one number - the converted amount on the above courses, rounded to 2 digits after the decimal point. 
 * 
 * Example:
 * 
 *  input    output
 *  20
 *  USD 
 *  BGN      35.91 BGN
 */

using System;

namespace Currency_converter
{
    class MainClass
    {
        public static void Main()
        {
            decimal currency = decimal.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;

            decimal result = 0m;

            if (inputCurrency == "USD")
            {
                result = currency * USD;

                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "EUR")
                {
                    result /= EUR;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "GBP")
                {
                    result /= GBP;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
            }
            else if (inputCurrency == "EUR")
            {
                result = currency * EUR;

                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "USD")
                {
                    result /= USD;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "GBP")
                {
                    result /= GBP;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
            }
            else if (inputCurrency == "GBP")
            {
                result = currency * GBP;

                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "USD")
                {
                    result /= USD;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "EUR")
                {
                    result /= EUR;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
            }
            else if (inputCurrency == "BGN")
            {
                result = currency;

                if (outputCurrency == "GBP")
                {
                    result /= GBP;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "USD")
                {
                    result /= USD;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
                else if (outputCurrency == "EUR")
                {
                    result /= EUR;

                    Console.WriteLine($"{result:f2} {outputCurrency}");
                }
            }
        }
    }
}
