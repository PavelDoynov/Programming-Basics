/*
 * 05. Number 0...9 to Text
 * 
 * Write a program that reads an integer in the [0 ... 9] range entered by the user and writes it in English words. 
 * If the number is out of range, it says "number too big". 
 * 
 * Examples:
 * Input Output       Input Output       Input Output      Input Output
 * 5     five         1     one          9     nine        10    number too big
*/


using System;

namespace Number_0_9_to_Text
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
