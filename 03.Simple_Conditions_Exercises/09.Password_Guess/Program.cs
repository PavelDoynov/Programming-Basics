/*
 * 09. Password Guess
 * 
 * Write a program that reads a password (one line with any text) entered by the user and checks if the input 
 * matches the phrase "s3cr3t!P@ssw0rd". Match "Welcome" to match.
 * In case of mismatch, "Wrong password!" Is displayed.
*/

using System;

namespace Password_Guess
{
    class MainClass
    {
        public static void Main()
        {
            string pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
