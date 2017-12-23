/*
 * 06. Bonus Score
 * 
 * An integer number is given. Bonus points based on the rules described below are charged.
 * Write a program that calculates the bonus points for that number and the total number of points with the bonuses.
 * • If the number is up to 100 inclusive, the bonus points are 5.
 * • If the number is greater than 100, the bonus points are 20% of the number.
 * • If the number is greater than 1000, the bonus points are 10% of the number.
 * • Additional bonus points (charged separately from the previous ones):
 *   o For even number → + 1 point.
 *   o For a number that ends at 5 → + 2 points.
 * 
 * Example:
 * Intput Output       Intput Output       Intput Output       Intput Output
 * 20     6            175    37           2703   270.3        15875  1587.5
 *        26                  212                 2973.3              17464.5
*/

using System;

namespace Bonus_Score
{
    class MainClass
    {
        public static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = number * 0.2;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number.ToString().EndsWith("5"))
            {
                bonus += 2;
            }

            Console.WriteLine($"{bonus}");
            Console.WriteLine($"{number + bonus}");
        }
    }
}
