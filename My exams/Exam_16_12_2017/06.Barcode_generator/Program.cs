/*
 * 06. Barcode Generator
 * 
 * The technique in a Christmas decoration shop is spoiled. 
 * Items that contain even numbers in their barcode can not be tagged by cashiers. 
 * Your task is to write a program that generates all the barcodes that do not contain even digits in itself.
 * 
 * Input:
 *   • Two four-digit numbers that indicate the range of barcodes you need to change. 
 *   • First line - four-digit number - the beginning of the range. An integer in the range [1000 ... 9999] 
 *   • Second row - four-digit - end of range. An integer in the range [1000 ... 9999]
 * 
 * Output:
 * All "barcodes" that do not contain an even number separated by a space must be printed on the console.
 * 
 * Example:
 * Input             Output
 *  2345             3355 3357 3359 3375 3377 3379 3555 3557 3559 
 *  6789             3575 3577 3579 3755 3757 3759 3775 3777 3779 
 *                   5355 5357 5359 5375 5377 5379 5555 5557 5559 
 *                   5575 5577 5579 5755 5757 5759 5775 5777 5779
*/

using System;

namespace Barcode_generator
{
    class MainClass
    {
        public static void Main()
        {
            
            char[] num1 = Console.ReadLine().ToCharArray();
            char[] num2 = Console.ReadLine().ToCharArray();



            for (char i = num1[0]; i <= num2[0]; i++)
            {
                for (char k = num1[1]; k <= num2[1]; k++)
                {
                    for (char j = num1[2]; j <= num2[2]; j++)
                    {
                        for (char a = num1[3]; a <= num2[3]; a++)
                        {
                            if (i % 2 != 0 && k % 2 != 0 && j % 2 != 0  && a % 2 != 0)
                            {
                                Console.Write($"{i}{k}{j}{a} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
