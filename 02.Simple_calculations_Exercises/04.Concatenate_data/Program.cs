/*
 * 04. Concatenate data
 * 
 * Write a C # program that reads the user's name, family, age, and town from the 
 * console and prints a message like this: "You are <firstName> <lastName>, <age> -years old person from <town> .
*/

using System;

namespace Concatenate_data
{
    class MainClass
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
