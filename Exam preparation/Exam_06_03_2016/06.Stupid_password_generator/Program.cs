/*
 * 06. Stupid password generator
 * 
 * Write a program that introduces two integers "n" and "l" and generate in alphabetical order 
 * all possible dumb passwords that consist of the following 5 characters:
 * 
 * • Symbol 1: Number from 1 through n.
 * • Symbol 2: Number from 1 through n.
 * • Symbol 3: a lowercase letter from the first letters of the Latin alphabet.
 * • Symbol 4: a lowercase letter from the first letters of the Latin alphabet.
 * • Symbol 5: a number from 1 to n, greater than the first 2 digits.
 * 
 * Input:
 * The input is read from the console and consists of two integers n and l in the range [1 ... 9], one per line.
 * 
 * Output:
 * All "dumb" passwords must be printed on the console in alphabetical order, separated by a space.
 * 
 *  Example:
 *   input output
 *    2
 *    4    11aa2 11ab2 11ac2 11ad2 11ba2 11bb2 11bc2 11bd2 11ca2 11cb2 11cc2 11cd2 11da2 11db2 11dc2 11dd2
*/

using System;

namespace Stupid_password_generator
{
    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sym1 = i;

                for (int a = 1; a <= n + l; a++)
                {
                    int sym2 = a;

                    for (char b = 'a'; b < 'a' + l; b++)
                    {
                        char sym3 = b;

                        for (char j = 'a'; j < 'a' + l; j++)
                        {
                            char sym4 = j;

                            for (int k = 1; k <= n; k++)
                            {
                                int sym5 = k;

                                if (sym5 > sym1 && sym5 > sym2)
                                {
                                    Console.Write($"{sym1}{sym2}{sym3}{sym4}{sym5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
