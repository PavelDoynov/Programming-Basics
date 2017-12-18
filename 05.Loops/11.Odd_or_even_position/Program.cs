/*
 * 11. Odd / Even Positions
 * 
 * Write a program that reads n-number of integers entered by the user and calculates the sum, minimum, 
 * and maximum of the even and odd positions (starting from 1). 
 * When there is no minimum / maximum element, print "No".
 * 
 * Format the output as follows:
 * "OddSum =" + {sum of odd numbers},
 * "OddMin =" + {minimum value of odd number} / {"No"},
 * "OddMax =" + {maximum number of odd numbers} / {"No"},
 * "EvenSum =" + {sum of the even position numbers},
 * "EvenMin =" + {minimum value of even-numbered numbers} / {"No"},
 * "EvenMax =" + {maximum value of even-numbered numbers} / {"No"}
*/

using System;

namespace Odd_or_even_position
{
    class MainClass
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            if (numbers == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");

            }
            else if (numbers == 1)
            {
                double numberOne = double.Parse(Console.ReadLine());

                Console.WriteLine($"OddSum={numberOne}");
                Console.WriteLine($"OddMin={numberOne}");
                Console.WriteLine($"OddMax={numberOne}");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                double oddSum = 0;
                double oddMin = double.MaxValue;
                double oddMax = double.MinValue;

                double evenSum = 0;
                double evenMin = double.MaxValue;
                double evenMax = double.MinValue;


                for (int i = 1; i <= numbers; i++)
                {
                    double currentNumber = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        oddSum += currentNumber;

                        if (currentNumber < oddMin)
                        {
                            oddMin = currentNumber;
                        }

                        if (currentNumber > oddMax)
                        {
                            oddMax = currentNumber;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        evenSum += currentNumber;

                        if (currentNumber < evenMin)
                        {
                            evenMin = currentNumber;
                        }

                        if (currentNumber > evenMax)
                        {
                            evenMax = currentNumber;
                        }
                    }
                }

                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");


            }
        }
    }
}
