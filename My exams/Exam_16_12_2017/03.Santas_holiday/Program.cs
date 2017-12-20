/* 
 * 03. Santas Holiday
 * 
 * Every year Santa selects different holiday destinations. 
 * This year he decided to spend his weekend in Bulgaria. His faithful friends, the dwarves, 
 * offer him a place in one of the most prestigious hotels, namely "Four seasons". 
 * During his stay there, he has to choose between the following types of accommodation with 
 * the following rates for stays:
 * 
 *   ▪ "room for one person" - 18.00 BGN per night 
 *   ▪ "apartment" - 25.00 BGN per night 
 *   ▪ "president apartment" - 35.00 BGN per night 
 * 
 * According to the number of days in which Santa will stay at the hotel (example: 11 days = 10 nights) 
 * and the type of room he / she will choose, he / she may have a different discount. 
 * The reductions on the days and the room are as follows:
 * 
 * type of room            less than 10 days           between 10 and 15 days        more than 15 days 
 * room for one person     does not use discount       no discount                   no discount 
 * apartment               30% of the final price      35% of the final price        50% of the final price 
 * president apartment     10% of the final price      15% of the final price        20% of the final price
 * 
 * After your stay at the hotel, Santa's valuation for hotel services may be positive or negative. 
 * If its rating is positive, Santa Claus adds 25% of the discount to the price already deducted. 
 * If its assessment is a negative deduction from the 10% price.
 * 
 * Input:
 * The entrance is read by the console and consists of three rows: 
 *   • First row - days for staying - an integer in the range [0 ... 365] 
 *   • Second row - room type for "one person", "apartment" president apartment "
 *   • Third row -" positive "or" negative "
 * 
 * Output:
 * A row should be printed on the console. 
 *   • The price for his stay at the hotel, formatted to the second mark after the decimal separator.
 * 
 * Example:
 * Input        Output
 * 11           203.13
 * apartment
 * positive
*/

using System;

namespace Santas_holiday
{
    class MainClass
    {
        public static void Main()
        {
            int daysForVacantion = int.Parse(Console.ReadLine());
            string roomForVacantion = Console.ReadLine();
            string positiveNegative = Console.ReadLine();

            int nights = daysForVacantion - 1;

            if (roomForVacantion == "room for one person")
            {
                double totalBill = nights * 18.00;

                if (positiveNegative == "positive")
                {
                    Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                }
                else if (positiveNegative == "negative")
                {
                    Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                }

            }
            else if (roomForVacantion == "apartment")
            {
                double totalBill = nights * 25.00;

                if (daysForVacantion < 10)
                {
                    totalBill = totalBill - (totalBill * 30) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }
                else if (daysForVacantion >= 10 && daysForVacantion <= 15)
                {
                    totalBill = totalBill - (totalBill * 35) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }
                else if (daysForVacantion > 15)
                {
                    totalBill = totalBill - (totalBill * 50) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }

            }
            else if (roomForVacantion == "president apartment")
            {
                double totalBill = nights * 35.00;

                if (daysForVacantion < 10)
                {
                    totalBill = totalBill - (totalBill * 10) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }
                else if (daysForVacantion >= 10 && daysForVacantion <= 15)
                {
                    totalBill = totalBill - (totalBill * 15) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }
                else if (daysForVacantion > 15)
                {
                    totalBill = totalBill - (totalBill * 20) / 100;

                    if (positiveNegative == "positive")
                    {
                        Console.WriteLine($"{totalBill + ((totalBill * 25) / 100):f2}");
                    }
                    else if (positiveNegative == "negative")
                    {
                        Console.WriteLine($"{totalBill - ((totalBill * 10) / 100):f2}");
                    }
                }
            }
        }
    }
}
