/*
 * 11. Equal Words
 * 
 * Write a program that reads two words entered by the user and checks if they are the same.
 * Do not make a difference between headwords and small words. 
 * Show "yes" or "no".
*/


using System;

namespace Equal_Words
{
    class MainClass
    {
        public static void Main()
        {
            string word1 = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
