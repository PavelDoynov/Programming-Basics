/*
 * 09. Vowels Sum
 * 
 * Write a program that reads a text (string) entered by the user and calculates and prints the sum of 
 * the values of the vowel letters according to the table below:
 * 
 * letter       a   e   i   o   u
 * value        1   2   3   4   5
 * 
 * Example:
 * input      output     logic
 * hello      6          e + o = 2 + 4 = 6
*/


using System;

namespace Vowels_sum
{
    class MainClass
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 'a')
                {
                    sum += 1;
                }
                else if (letter == 'e')
                {
                    sum += 2;
                }
                else if (letter == 'i')
                {
                    sum += 3;
                }
                else if (letter == 'o')
                {
                    sum += 4;
                }
                else if (letter == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
