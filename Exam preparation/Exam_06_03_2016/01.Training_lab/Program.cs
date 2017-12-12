/*
 * 01. Training lab
 * 
 * The study room has a rectangular size w at h meters, with no columns in the interior. 
 * The hall is divided into two parts - left and right, with a corridor approximately in the middle. 
 * There are rows of desks in the left and right. In the back of the hall there is a large front door.
 * In the front of the hall there is a department with a pedestrian pedestal. One workstation occupies 
 * 70 to 120 cm (table size 70 to 40 cm + seat for chair and 70 cm to 80 cm). 
 * The corridor is at least 100 cm wide. It is estimated that because of the entrance door 
 * (which has a hole of 160 cm), exactly 1 job is lost, and because of the department 
 * (which is 160 to 120 cm), exactly 2 jobs are lost. Write a program that introduces the size of the 
 * classroom and calculates the number of work places in the room described above.
 * 
 * Input:
 * The console reads 2 numbers, one per line: w (length in meters) and h (width in meters).
 * Limitations: 3 ≤ h ≤ w ≤ 100.
 * 
 * Output:
 * Print an integer on the console: the number of places in the classroom.
*/

using System;

namespace Training_lab
{
    class MainClass
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int lengthWork = (int)(length * 100) / 120;
            int widthWork = (int)((width * 100) - 100) / 70;

            int sum = lengthWork * widthWork - 3;

            Console.WriteLine(sum);

        }
    }
}
