/*
 * 03. Greeting by name
 * 
 * Write a program that reads the user's name from the console and prints "Hello, <name>!"
 * Where <name> is the previously entered name.
*/

using System;

namespace Greeting_by_name
{
    class MainClass
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
