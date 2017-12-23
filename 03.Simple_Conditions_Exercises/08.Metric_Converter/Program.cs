/*
 * 08. Metric Converter
 * 
 * Write a program that translates a distance between the following 8 units: m, mm, cm, mi, in, km, ft, yd. 
 * Use the tabs below:
 * 
 * input unit       output unit
 * 1 meter (m)      1000 millimeters (mm)
 * 1 meter (m)      100 centimeters (cm)
 * 1 meter (m)      0.000621371192 miles (mi)
 * 1 meter (m)      39.3700787 inches (in)
 * 1 meter (m)      0.001 kilometers (km)
 * 1 meter (m)      3.2808399 feet (ft)
 * 1 meter (m)      1.0936133 yards (yd)
 * 
 * Input data consists of three lines entered by the user:
 *   • First line: conversion number
 *   • Second line: input unit
 *   • Third row: output unit (for the result)
 * Format the result to eight decimal places.
 * 
 * Example:
 * Input   Output
 * 12      39370. 07886932
 * km
 * ft  
*/



using System;

namespace Metric_Converter
{
    class MainClass
    {
        public static void Main()
        {
            double distance = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "mm")
            {
                distance = distance / 1000;
            }
            else if (inputUnit == "cm")
            {
                distance = distance / 100;
            }
            else if (inputUnit == "mi")
            {
                distance = distance / 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                distance = distance / 39.3700787;
            }
            else if (inputUnit == "km")
            {
                distance = distance / 0.001;
            }
            else if (inputUnit == "ft")
            {
                distance = distance / 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                distance = distance / 1.0936133;
            }

            if (outputUnit == "mm")
            {
                distance *= 1000;
            }
            else if (outputUnit == "cm")
            {
                distance *= 100;
            }
            else if (outputUnit == "mi")
            {
                distance *= 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                distance *= 39.3700787;
            }
            else if (outputUnit == "km")
            {
                distance *= 0.001;
            }
            else if (outputUnit == "ft")
            {
                distance *= 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                distance *= 1.0936133;
            }

            Console.WriteLine($"{distance:f8}");
        }
    }
}
