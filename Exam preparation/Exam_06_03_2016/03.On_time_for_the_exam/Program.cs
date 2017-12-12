/*
 * 03. On time for the exam
 * 
 * A student must go to an exam at a specific time (for example at 9:30). He comes to the exam 
 * room at a certain time of arrival (eg, 9:40). It is believed that the student has come in time if 
 * he/she has arrived at the exam hour or half an hour before. 
 * If he has arrived earlier than 30 minutes, he has started. If he came after the exam, he was late. 
 * Write a program that introduces exam time and arrival time and prints out whether the student has 
 * arrived on time, whether he has started or is late, and how many hours or minutes he has started or is late.
 * 
 * Input:
 * The console reads 4 integers (one per line):
 * • The first line contains an exam hour - an integer from 0 to 23.
 * • The second line contains a minute of the exam - an integer from 0 to 59.
 * • The third line contains an arrival time - an integer from 0 to 23.
 * • The fourth line contains a minute of arrival - an integer from 0 to 59.
 * 
 * Output:
 * On the first line print:
 * • "Late" if the student arrives later than the exam time.
 * • "On time" if the student arrives exactly at the exam time or up to 30 minutes in advance.
 * • "Early" if the student arrives more than 30 minutes before the exam.
 * If the student arrives at least a minute of the exam's time, print the following line:
 * • "mm minutes before the start" to arrive earlier in less than an hour.
 * • "hh: mm hours before the start" for annoying 1 hour or more. Always print the minutes with 2 digits, for example "1:05".
 * • "mm minutes after the start" for an hour's delay.
 * • "hh: mm hours after start" for a delay of 1 hour or more. Always print the minutes with 2 digits, for example "1:03".
 * 
 * Example:
 * Input Output
 * 9      Late
 * 00     1:30 hours after the start
 * 10
 * 30  
*/

using System;

namespace On_time_for_the_exam
{
    class MainClass
    {
        public static void Main()
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfStudent = int.Parse(Console.ReadLine());
            int minuteOfStudent = int.Parse(Console.ReadLine());

            int sumExamMinutes = hourOfExam * 60 + minuteOfExam;
            int sumStudentMinutes = hourOfStudent * 60 + minuteOfStudent;

            if (sumExamMinutes >= sumStudentMinutes)
            {
                if (sumExamMinutes - sumStudentMinutes == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (sumExamMinutes - sumStudentMinutes <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", sumExamMinutes - sumStudentMinutes);
                }
                else if (sumExamMinutes - sumStudentMinutes > 30 && sumExamMinutes - sumStudentMinutes < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", sumExamMinutes - sumStudentMinutes);
                }
                else if (sumExamMinutes - sumStudentMinutes >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:D2} hours before the start", (sumExamMinutes - sumStudentMinutes) / 60, 
                                      (sumExamMinutes - sumStudentMinutes) % 60);
                }
            }
            else if (sumExamMinutes < sumStudentMinutes)
            {
                if (sumStudentMinutes - sumExamMinutes < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", sumStudentMinutes - sumExamMinutes);
                }
                else if (sumStudentMinutes - sumExamMinutes >= 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:D2} hours after the start", (sumStudentMinutes - sumExamMinutes) / 60,
                                      (sumStudentMinutes - sumExamMinutes) % 60);
                }
            }


        }
    }
}
