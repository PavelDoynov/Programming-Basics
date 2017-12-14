/* 
 * 02. Pipes in the pool
 * 
 * A pool with volume V has two pipes to fill. 
 * Each pipe has a specific flow (liters of water passing through one tube per hour). 
 * The worker runs the pipes at the same time and goes out for N hours. 
 * Write down a program that takes the condition of the pool at the moment the worker returns.
 * 
 * Input:
 * Four rows are read from the console:
 * • The first row contains the number V - Pool volume in liters - an integer in the range [1 ... 10000].
 * • The second row contains the number P1 - the flow of the first pipe per hour - an integer in the range [1 ... 5000].
 * • The third row contains the number P2 - the second pipe flow per hour integer in the range [1 ... 5000].
 * • The fourth row contains the number H - the hours the worker is absent - a floating point in the range [1.0 ... 24.00]
 * 
 * Output:
 * Print one of two possible states on the console:
 * • How far the pool has been filled and which tube has contributed to the percentage. All percentages are reduced to an integer (without rounding).
 *            "The pool is [x]% full. Pipe 1: [y]%. Pipe 2: [z]%."
 * • If the pool has overflowed - how many liters it has overflowed for a given time, a float point
 *            "For [x] hours the pool overflows with [y] liters."
 * 
 *    *Keep in mind that data is lost due to an integer, and that the sum of percentages is 99% rather than 100%.
*/

using System;

namespace Pipes_in_the_pool
{
    class MainClass
    {
        public static void Main()
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumPipeOneVolume = pipeOne * hours;
            double sumPipeTwoVolume = pipeTwo * hours;
            double sumPipesvolume = sumPipeOneVolume + sumPipeTwoVolume;

            if (sumPipesvolume <= poolVolume)
            {
                double poolFillPercentage = Math.Truncate((sumPipesvolume * 100) / poolVolume);

                int pipeOnePercentage = (int)Math.Truncate((sumPipeOneVolume * 100) / sumPipesvolume);
                int pipeTwoPercentage = (int)Math.Truncate((sumPipeTwoVolume * 100) / sumPipesvolume);

                Console.WriteLine($"The pool is {poolFillPercentage}% full. Pipe 1: {(int)pipeOnePercentage}%." +
                                  $" Pipe 2: {(int)pipeTwoPercentage}%.");
            }
            else
            {
                double poolOverflows = sumPipesvolume - (double)poolVolume;

                Console.WriteLine($"For {hours} hours the pool overflows with {poolOverflows:f1} liters.");
            }
        }
    }
}
