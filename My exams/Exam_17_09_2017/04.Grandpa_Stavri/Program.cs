/*
 * 04. Grandpa Stavri
 * 
 * Grandpa Stavri has a kettle for brandy and every day he drinks his favorite drink. If it is boiled N days 
 * and every day gets a different amount of brandy and alcoholic strength, 
 * find the total amount of brandy and the degree of the resulting mixture for all days.
 * 
 * Input:
 * A sequence of numbers is read from the console, each on a single line: 
 *   1. On the first line - N - number of days - an integer [1 ... 300] 
 *   2. For each day on a separate line: 
 *      - Quantity of brandy - in the interval [1.00 ... 500.00] 
 *      - degree of the obtained beverage - real number in the interval [10.00 ... 99.00] 
 * 
 * Output:
 * Print a row of 3 lines as follows: 
 *   1. First line - print a message formatted to the second character "Liter: {total literals}" 
 *   2. Second line - Print a message formatted to the second character "Degrees: {degrees of total mixture}; 
 *   3. Third line - to print: 
 *     - If the degree is less than 38, print the message "Not good, you should baking!". 
 *     - If 38 to 42, print "Super!" 
 *     - If more than 42, print "Dilution with distilled water!" 
 * 
 * Example:
 * Input       Output
 * 3           Liter: 300
 * 100         Degrees: 42.17
 * 45          Dilution with distilled water!
 * 50
 * 55
 * 150
 * 36
*/

using System;

namespace Grandpa_Stavri
{
    class MainClass
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());

            double totalDegrees = 0;
            double totalLiters = 0;

            for (int i = 0; i < days; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                totalLiters += liters;
                totalDegrees += (liters * degrees);
            }

            double result = (totalDegrees / totalLiters);

            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {result:f2}");

            if (result < 38.00)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (result >= 38.00 && result <= 42.00)
            {
                Console.WriteLine("Super!");
            }
            else if (result > 42.00)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
