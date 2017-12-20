/*
 * 02. Deers of Santa
 * 
 * Santa loves to travel very much, but unfortunately it happened, so just before 
 * going on vacation three of the deer got sick and had to leave them. 
 * When he leaves, he has to figure out how much food he will leave to each of the deer so he does not get hungry.
 * Write down a program that calculates whether Santa Claus's food will be sufficient for the time he will not have it. 
 * Each deer eats a certain amount of food per day.
 * 
 * Input:
 * Five lines are read from the console: 
 *   • First row - number of days in which Santa is absent - an integer in the range [1 ... 5000] 
 *   • Second row - food left in kilograms - integer [0 ... 100000] 
 *   • Third row - food per day for the first deer in kilograms - real number in the interval [0.00 ... 100.00] 
 *   • Fourth row - food per day for the second deer in kilograms in the range [0.00 ... 100.00] 
 *   • Fifth row - food per day for the third deer in kilograms - real number in the range [0.00 ... 100.00]
 * 
 * Output:
 * The console should be printed in one line:
 *   - If the food left is sufficient: 
 *     o {kilogram remainder} kilos of food left.} 
 *       ▪ The result must be rounded to the LOWER integer. 
 *   - If the food left is NOT sufficient: 
 *     o "{Kilo shortage} more kilos of food are needed." 
 *       ▪ The result must be rounded to the HIGHER integer.
 * 
 * Example:
 * Input     Output           
 * 2         2 kilos of food left
 * 10
 * 1
 * 1
 * 2
*/

using System;

namespace Deer_of_santa
{
    class MainClass
    {
        public static void Main()
        {
            int santaGoneAway = int.Parse(Console.ReadLine());
            int foodForDeers = int.Parse(Console.ReadLine());
            double foodForFirstDeer = double.Parse(Console.ReadLine());
            double foodForSecondDeer = double.Parse(Console.ReadLine());
            double foodForThirdDeer = double.Parse(Console.ReadLine());

            double neededFoodForFirstDeer = santaGoneAway * foodForFirstDeer;
            double neededFoodForSecondDeer = santaGoneAway * foodForSecondDeer;
            double neededFoodForThirdDeer = santaGoneAway * foodForThirdDeer;
            double totalFood = neededFoodForFirstDeer + neededFoodForSecondDeer 
                + neededFoodForThirdDeer;

            if (totalFood <= foodForDeers)
            {
                Console.WriteLine($"{Math.Floor(foodForDeers - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodForDeers)} more kilos of food are needed.");
            }
        }
    }
}
