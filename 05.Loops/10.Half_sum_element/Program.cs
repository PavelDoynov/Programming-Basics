/*
 * 10 Half Sum Element
 * 
 * Write a program that reads n-number integers entered by the user and checks if 
 * there is a number equal to the sum of all others. If there is such an element, 
 * print "Yes", "Sum =" + its value; else the "No", "Diff =" + the difference between 
 * the largest element and the sum of the rest (in absolute terms).
*/

using System;

namespace Half_sum_element
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumOfNumbers = 0;
            int biggestNumber = 0;

            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sumOfNumbers += currentNumber;

                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
            }

            sumOfNumbers -= biggestNumber;

            if (sumOfNumbers == biggestNumber)
            {
                Console.WriteLine("Yes, Sum = {0}", biggestNumber);
            }
            else
            {
                int result = Math.Abs(sumOfNumbers - biggestNumber);
                Console.WriteLine($"No, Diff = {result}");
            }
        }
    }
}
