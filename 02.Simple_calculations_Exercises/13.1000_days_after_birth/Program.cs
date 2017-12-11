/*
 * 12. 1000 Days
 * 
 * Write a program that reads the date of birth in dd-MM-yyyy format entered by the user and calculates 
 * the date of 1000 days of that date and prints it in the same format.
 * Example:
 * 
 *     input      output
 *  25-02-1995  20-11-1997
 *  07-11-2003  02-08-2006
 * 
 * Search for the DateTime type information in C # and specifically look 
 * at the ParseExact (str, format), AddDays (count), and ToString (format) methods. 
 * With their help you can solve the task without having to calculate days, months and leap years.
*/

using System;
using System.Globalization;

namespace _days_after_birth
{
    class MainClass
    {
        public static void Main()
        {
            string birthDate = Console.ReadLine();

            DateTime newDate = DateTime.ParseExact(birthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                                     .AddDays(999);

            Console.WriteLine($"{newDate.ToString("dd-MM-yyyy")}");
        }
    }
}
