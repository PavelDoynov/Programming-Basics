/*
 * 04. Dwarf Presents
 * 
 * After her break at the hotel, Santa decided to surprise the dwarves by taking a souvenir from Bulgaria. 
 * The first line will read the N-number from the console, which will account for the number of dwarves. 
 * On the second line you will read the amount that Santa Claus has. The following N lines will read the 
 * types of gifts that Santa Claus will take for each of the dwarves. The types of gifts are as follows:
 *   • sand clock 
 *   • magnet 
 *   • cup 
 *   • t-shirt 
 * Your task is to calculate the entire amount for the gifts and to check if the money Santa has is sufficient. 
 * The price for each of the presents is as follows: 
 *   • sand clock - 2.20 lv 
 *   • magnet - 1.50 lv 
 *   • cup - 5.00 lv 
 *   • t-shirt - 10.00 lv
 * 
 * Input:
 * The input is read from the console: 
 *   • First row - the number of dwarves - an integer in the range [1 ... 50] 
 *   • Second row - the money Santa has at its disposal - an integer in the range [1 ... 1000] 
 *   • The next N rows - the kind of gift every dwarf will get
 * 
 * Output:
 * Print on the console 1 line: 
 * If Santa's money is enough: 
 *   • Santa Claus has {remaining money} more leva left! 
 * If Santa's money is insufficient: 
 *   • Santa Claus will need {no money} more leva. 
 * The result must be formatted to the SECOND mark after the decimal separator.
 * 
 * Example:
 * Input      Output
 * 5          Santa Claus has 79.80 more leva left!
 * 100
 * sand clock
 * magnet
 * t-shirt
 * cup
 * magnet
*/

using System;

namespace Dwarf_presents
{
    class MainClass
    {
        public static void Main()
        {
            int numberOfDwarf = int.Parse(Console.ReadLine());
            double moneyForPresents = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 1; i <= numberOfDwarf; i++)
            {
                string presents = Console.ReadLine();

                if (presents == "sand clock")
                {
                    totalMoney += 2.20;
                }
                else if (presents == "cup")
                {
                    totalMoney += 5.00;
                }
                else if (presents == "magnet")
                {
                    totalMoney += 1.50;
                }
                else if (presents == "t-shirt")
                {
                    totalMoney += 10.00;
                }
            }

            if (moneyForPresents >= totalMoney)
            {
                Console.WriteLine($"Santa Claus has {Math.Abs((totalMoney - moneyForPresents)):f2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {Math.Abs((moneyForPresents - totalMoney)):f2} more leva.");
            }
        }
    }
}
