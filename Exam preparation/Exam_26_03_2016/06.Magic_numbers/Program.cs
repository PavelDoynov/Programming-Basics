/*
 * 06. Magic numbers
 * 
 * Write a program that introduces a whole "magical" number and produces all possible 6-digit 
 * numbers for which the output of its digits is equal to the "magical" number.
 * 
 * Example: The Magic number is 2:
 * 
 * •   111112 -> 1 * 1 * 1 * 1 * 1 * 2 = 2
 * •   111121 -> 1 * 1 * 1 * 1 * 2 * 1 = 2
 * •   111211 -> 1 * 1 * 1 * 2 * 1 * 1 = 2
 * •   112111 -> 1 * 1 * 2 * 1 * 1 * 1 = 2
 * •   121111 -> 1 * 2 * 1 * 1 * 1 * 1 = 2
 * •   211111 -> 2 * 1 * 1 * 1 * 1 * 1 = 2
 *
 * 
 * Input:
 * The input is read from the console and consists of an integer in the range [1 ... 600000].
 * 
 * Output:
 * All "magic" numbers separated by a space must be printed on the console.
 * 
 * Example:
 * Input:      Output:
 *  2          111112 111121 111211 112111 121111 211111
 * 
 *  8          111118 111124 111142 111181 111214 111222 111241 111412 111421 111811 
 *             112114 112122 112141 112212 112221 112411 114112 114121 114211 118111 
 *             121114 121122 121141 121212 121221 121411 122112 122121 122211 124111 
 *             141112 141121 141211 142111 181111 211114 211122 211141 211212 211221 
 *             211411 212112 212121 212211 214111 221112 221121 221211 222111 241111 
 *             411112 411121 411211 412111 421111 811111
 * 
 *  531441     999999
*/

using System;

namespace Magic_numbers
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            for (int i5 = 0; i5 <= 9; i5++)
                            {
                                for (int i6 = 0; i6 <= 9; i6++)
                                {
                                    if (i1 * i2 * i3 * i4 * i5 * i6 == number)
                                    {
                                        Console.Write($"{i1}{i2}{i3}{i4}{i5}{i6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
