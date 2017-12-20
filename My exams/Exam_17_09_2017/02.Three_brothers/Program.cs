/*
 * 02. Three Brothers
 * 
 * Three brothers decided to surprise their father by cleaning his garage together. 
 * The big brother cleaned himself for certain hours - A. 
 * The average brother cleaned himself for B hours. The younger brother cleaned himself for C hourss. 
 * The father goes fishing for fish and will not have D hours.
 * Write a program that calculates whether the three brothers can clear the garage together 
 * and surprise their father or not.
 * To the total cleaning time add 15% for rest.
 * 
 * Input:
 * The input is read from the console and consists of 4 rows:
 *   - The time of the first brother for cleaning alone - a real number in the range [0.00 ... 99.00]
 *   - The time of the second brother for cleaning alone - a real number in the range [0.00 ... 99.00]
 *   - The time of the third brother for cleaning itself - real number in the range [0.00 ... 99.00]
 *   - Fishing time for the father - real number in the range [0.00 ... 99.00]
 * 
 * Output:
 * Two rows should be printed on the console.
 * 1. Cleaning and rest time formatted to the second character: "Cleaning time: {Cleaning time}"
 * 2. Is there a surprise or not:
 *   - If the brothers have surprised the father (time left> 0): "Yes, there is a surprise - time left -
 *          {remainder} hours. "- the result must be rounded to a smaller integer (eg 1.90 -> 1).
 *   - If the brothers did not surprise the father: "No, there is no surprise - lack of time -
 *          {shortage} hours. "- the result must be rounded to a larger integer (eg 1.10 -> 2).
*/

using System;

namespace Three_brothers
{
    class MainClass
    {
        public static void Main()
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherGoForFishing = double.Parse(Console.ReadLine());

            double totalTimeForCleaning = 1 / (1 / firstBrother + 1 / secondBrother
                                               + 1 / thirdBrother);

            double timeForCleaningWithRest = totalTimeForCleaning + (totalTimeForCleaning * 0.15);

            double result = Math.Abs(fatherGoForFishing - timeForCleaningWithRest);

            if (timeForCleaningWithRest <= fatherGoForFishing)
            {
                Console.WriteLine($"Cleaning time: {timeForCleaningWithRest:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(result)} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {timeForCleaningWithRest:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(result)} hours.");
            }
        }
    }
}
