/*
 * 06. The song of the wheels
 * 
 * Sali Yashar's right-hander has received an inheritance - a password safe - four digits. 
 * The mystery of the singing carts is locked in it. He has an auto service and needs advertising, 
 * so he decided to make such a wagon. The problem is that the password is hidden in the following task:
 * 
 *                    "You will get a password if you know an integer, a control value is called it,
 *                     rests in the range of 4 to 144 inclusive, but finding it may be painful. "
 * 
 * The password has the format "abcd" and the control value must be a * b + c * d, but the following 
 * conditions must be met:
 *    - Finding a and b: a < b 
 *    - Finding c and d: c > d
 * 
 * The wagon has four wheels, so the password will be the fourth number to be printed. If NO is found, print "No!".
 * 
 * Input:
 * The console reads one integer (control value): M - an integer in the range [4 ... 144];
 * 
 * Output:
 * The printout of the console depends on the result: 
 *   1. If quadrants (abcd) are found meeting the condition, we print them all with a spacing interval: "{a} {b} {c} {d}" 
 *   2. Print one of the two rows of new line: 
 *      - If the fourth quadruple is printed: "Password: {a} {b} {c} {d}" 
 *      - If no such numbers are found or no fourth quartet is printed: "No!"
 * 
 * Example:
 * Input      Output
 * 11         1291 1342 1381 1471 
 *            1532 1561 1651 1741 
 *            1831 1921 2351 2431 
 *            Password: 1471
*/

using System;

namespace The_song_of_the_wheels
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int currentCount = 0;
            int numA = 0;
            int numB = 0;
            int numC = 0;
            int numD = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (number == a * b + c * d)
                            {
                                if (a < b && c > d)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    currentCount += 1;

                                    if (currentCount == 4)
                                    {
                                        numA = a;
                                        numB = b;
                                        numC = c;
                                        numD = d;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (currentCount >= 4)
            {
                Console.WriteLine($"Password: {numA}{numB}{numC}{numD}");
            }
            else if (currentCount < 4)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
