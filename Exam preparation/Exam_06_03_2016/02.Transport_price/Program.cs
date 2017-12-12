/*
 * 02. Transport price
 * 
 * A student should travel a kilometer. He has a choice of three types of transport:
 * • Taxi. Starting fee: 0.70 BGN Daily rate: 0.79 BGN / km. Night rate: 0.90 BGN / km.
 * • Bus. Day / night rate: 0.09 BGN / km. It can be used for distances of at least 20 km.
 * • Train. Day / night rate: 0.06 BGN / km. Can be used for distances of at least 100 km.
 * 
 * Write a program that enters the number of kilometers n and a day period (day or night) and 
 * calculates the cost of the cheapest transportation.
 * 
 * Input:
 * The console reads two lines:
 * • The first line contains the number n - number of kilometers - an integer in the range [1 ... 5000].
 * • The second line contains the word "day" or "night" - a day or night trip.
 * 
 * Output:
 * Print the console at the lowest price for the specified distance.
*/

using System;

namespace Transport_price
{
    class MainClass
    {
        public static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();

            double result = 0;

            if (distance < 20)
            {
                if (dayNight == "day")
                {
                    result = 0.70 + 0.79 * distance;
                }
                else if (dayNight == "night")
                {
                    result = 0.70 + 0.90 * distance;
                }
            }
            else if (distance >= 20 && distance < 100)
            {
                result = distance * 0.09;
            }
            else if (distance >= 100)
            {
                result = distance * 0.06;
            }

            Console.WriteLine(result);
        }
    }
}
