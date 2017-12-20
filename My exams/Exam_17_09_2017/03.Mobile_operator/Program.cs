/*
 * 03. Mobile Operator
 * 
 * Mobile operator offers contracts with a different monthly fee depending on the term - 1 or 2 years. 
 * Write a program that calculates the due amount to be paid for a certain number of months.
 * 
 * term / type      Small        Middle       Large       ExtraLarge
 * 1 year           9.98 lv.     18.99 lv.    25.98 lv.   35.99 lv.
 * 2 years          8.58 lv.     17.09 lv.    23.59 lv.   31.79 lv.
 * 
 * Conditions: 
 *  * with added mobile internet, the following fee is added: 
 *      - for an amount less than or equal to BGN 10.00 -> 5.50 BGN 
 *      - for an amount less than or equal to BGN 30.00 -> 4.35 BGN 
 *      - for a sum greater than BGN 30.00 -> 3.85 BGN  
 *  * if the two-year contract, the total amount is reduced by 3.75%
 * 
 * Input:
 * From the console are read 3 lines: 
 *    1. term of the contract - text - one or two 
 *    2. contract type - text - "Small", "Middle", "Large" or "ExtraLarge"; 
 *    3. added internet - text "yes" or "no" 
 *    4. number of months for payment - an integer in the range [1 ... 24];
 * 
 * Output:
 * The console prints 1 line: 
 *    -  The price paid by the customer, formatted to the second decimal place, in the following format: "{price} lv."
 * 
 * Example:
 * Input     Output:
 * one       154.80 lv.
 * Small
 * yes
 * 10
*/

using System;

namespace Mobile_operator
{
    class MainClass
    {
        public static void Main()
        {
            string contractTerm = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;

            if (contractTerm == "one")
            {
                if (contractType == "Small")
                {
                    if (internet == "yes")
                    {
                        price = (9.98 + 5.50) * months;
                    }
                    else if (internet == "no")
                    {
                        price = 9.98 * months;
                    }
                }
                else if (contractType == "Middle")
                {
                    if (internet == "yes")
                    {
                        price = (18.99 + 4.35) * months;
                    }
                    else if (internet == "no")
                    {
                        price = 18.99 * months;
                    }
                }
                else if (contractType == "Large")
                {
                    if (internet == "yes")
                    {
                        price = (25.98 + 4.35) * months;
                    }
                    else if (internet == "no")
                    {
                        price = 25.98 * months;
                    }
                }
                else if (contractType == "ExtraLarge")
                {
                    if (internet == "yes")
                    {
                        price = (35.99 + 3.85) * months;
                    }
                    else if (internet == "no")
                    {
                        price = 35.99 * months;
                    }
                }
            }
            else if (contractTerm == "two")
            {
                if (contractType == "Small")
                {
                    if (internet == "yes")
                    {
                        price = (8.58 + 5.50) * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                    else if (internet == "no")
                    {
                        price = 8.58 * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                }
                else if (contractType == "Middle")
                {
                    if (internet == "yes")
                    {
                        price = (17.09 + 4.35) * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                    else if (internet == "no")
                    {
                        price = 17.09 * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                }
                else if (contractType == "Large")
                {
                    if (internet == "yes")
                    {
                        price = (23.59 + 4.35) * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                    else if (internet == "no")
                    {
                        price = 23.59 * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                }
                else if (contractType == "ExtraLarge")
                {
                    if (internet == "yes")
                    {
                        price = (31.79 + 3.85) * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                    else if (internet == "no")
                    {
                        price = 31.79 * months;
                        double percentage = price * 0.0375;
                        price -= percentage;
                    }
                }
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
