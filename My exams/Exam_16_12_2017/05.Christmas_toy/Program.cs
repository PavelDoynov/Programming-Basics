/*
 * 05. Christmas Toy
 * 
 * Write a program that reads from the console a very even number n, as in the examples below. 
 * The Christmas toy has a width of 5 * n and a height of 2 * n + 3. Your task is to create a 
 * program to print the Christmas toy.
 * 
 * Input:
 * The input is read from the console and contains an even even number n in the range [2 ... 22].
 * 
 * Output:
 * Print the Christmas toy on the console, just as in the examples.
 * 
 * Example
 * Input                 Output
 * 6         ------------******------------ 
 *           ----------*&&&&&&&&*---------- 
 *           --------**&&&&&&&&&&**-------- 
 *           ------***&&&&&&&&&&&&***------ 
 *           -----**~~~~~~~~~~~~~~~~**----- 
 *           ----**~~~~~~~~~~~~~~~~~~**---- 
 *           ---**~~~~~~~~~~~~~~~~~~~~**--- 
 *           ---*||||||||||||||||||||||*--- 
 *           ---**~~~~~~~~~~~~~~~~~~~~**--- 
 *           ----**~~~~~~~~~~~~~~~~~~**---- 
 *           -----**~~~~~~~~~~~~~~~~**----- 
 *           ------***&&&&&&&&&&&&***------ 
 *           --------**&&&&&&&&&&**-------- 
 *           ----------*&&&&&&&&*---------- 
 *           ------------******------------ 
*/

using System;

namespace Christmas_toy
{
    class MainClass
    {
        public static void Main()
        {
            int christmasToy = int.Parse(Console.ReadLine());

            if (christmasToy % 2 == 0)
            {

                Console.WriteLine("{0}{1}{0}", new string('-', christmasToy * 2), new string('*', christmasToy));

                int count = 1;

                int count2 = 2;

                for (int i = 1; i <= christmasToy / 2; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', christmasToy * 2 - count2), new string('*', count), 
                                      new string('&', christmasToy + count2));
                    count += 1;
                    count2 += 2;
                }

                int count3 = 1;

                for (int i = 1; i <= christmasToy / 2; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', christmasToy - count3), new string('*', 2),
                                      new string('~',  (christmasToy * 5) - ((christmasToy - count3) * 2) - 4));
                    count3 += 1;

                } 

                Console.WriteLine("{0}*{1}*{0}", new string('-', christmasToy /2), 
                                  new string('|', (christmasToy * 5) - christmasToy - 2));

                for (int i = 1; i <= christmasToy / 2; i++)
                {
                    count3 -= 1;

                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', christmasToy - count3), new string('*', 2),
                                      new string('~', (christmasToy * 5) - ((christmasToy - count3) * 2) - 4));
                    
                }
                for (int i = 1; i <= christmasToy / 2; i++)
                {
                    count -= 1;
                    count2 -= 2;
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', christmasToy * 2 - count2), new string('*', count),
                                      new string('&', christmasToy + count2));
                    
                }

                Console.WriteLine("{0}{1}{0}", new string('-', christmasToy * 2), new string('*', christmasToy));


            }
        }
    }
}
