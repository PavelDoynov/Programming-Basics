/*
 * 03. Journey
 * 
 * Strangely, but most people plan ahead of the break. A young programmer has a 
 * certain budget and free time in a given season. 
 * Write a program that will accept the budget and season entry, and at the exit to earn, 
 * where the developer will rest and how much he will spend.
 * The budget determines the destination and the season determines how much 
 * of the budget it will spend. If it is summer, it will rest on a camping site and 
 * winter at a hotel. If it is in Europe, regardless of the season will rest in a hotel. 
 * Each campsite or hotel, according to the destination, has its own price that corresponds 
 * to a given percentage of the budget:
 * • At 100lv. or less - somewhere in Bulgaria
 *   - Summer - 30% of the budget
 *   - Winter - 70% of the budget
 * • At 1000lv. or less - somewhere in the Balkans
 *   - Summer - 40% of the budget
 *   - Winter - 80% of the budget
 * • At more than 1000 leva. - somewhere in Europe
 *   - When traveling across Europe, regardless of the season, it will spend 90% of the budget.
 * 
 * Input:
 * The input is read from the console and consists of two rows:
 * • First line - Budget, real number in the range [10.00 ... 5000.00].
 * • Second line - One of two possible seasons: "summer" or "winter"
 * 
 * Output:
 * Two rows should be printed on the console.
 * • First line - "Somewhere in [destination]" from "Bulgaria", "Balkans" and "Europe"
 * • Second line - "{Vacation type} - {Spent amount}"
 *   - The vacation may be between "Camp" and "Hotel"
 *   - The sum must be rounded to the second digit after the comma.
*/

using System;

namespace Journey
{
    class MainClass
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");

                    double total = (budget * 30) / 100;

                    Console.WriteLine($"Camp - {total:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");

                    double total = (budget * 70) / 100;

                    Console.WriteLine($"Hotel - {total:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");

                    double total = (budget * 40) / 100;

                    Console.WriteLine($"Camp - {total:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");

                    double total = (budget * 80) / 100;

                    Console.WriteLine($"Hotel - {total:f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");

                double total = (budget * 90) / 100;

                Console.WriteLine($"Hotel - {total:f2}");
            }
        }
    }
}
