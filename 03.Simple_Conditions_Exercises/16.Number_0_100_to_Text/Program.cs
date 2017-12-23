/*
 * 16. Number 0...100 to Text
 * 
 * Write a program that converts a number [0 ... 100] into text: 
 * 25 → "twenty five"
*/

using System;

namespace Number_0_100_to_Text
{
    class MainClass
    {
        public static void Main()
        {
            int intputNumber = int.Parse(Console.ReadLine());

            if (intputNumber >= 0 && intputNumber <= 100)
            {
                string number = intputNumber.ToString();

                if (number.Length == 1)
                {
                    switch (number)
                    {
                        case "0":
                            Console.WriteLine("zero");
                            break;

                        case "1":
                            Console.WriteLine("one");
                            break;

                        case "2":
                            Console.WriteLine("two");
                            break;

                        case "3":
                            Console.WriteLine("three");
                            break;

                        case "4":
                            Console.WriteLine("four");
                            break;

                        case "5":
                            Console.WriteLine("five");
                            break;

                        case "6":
                            Console.WriteLine("six");
                            break;

                        case "7":
                            Console.WriteLine("seven");
                            break;

                        case "8":
                            Console.WriteLine("eight");
                            break;

                        case "9":
                            Console.WriteLine("nine");
                            break;

                        default:
                            break;
                    }
                }
                else if (number.Length == 2)
                {

                    if (number == "10" || number == "11" || number == "12" || number == "13" ||
                        number == "14" || number == "15" || number == "16" || number == "17" ||
                        number == "18" || number == "19" || number == "20" || number == "30" ||
                        number == "40" || number == "50" || number == "60" || number == "70" ||
                        number == "80" || number == "90")
                    {
                        switch (number)
                        {
                            case "10":
                                Console.WriteLine("ten");
                                break;

                            case "11":
                                Console.WriteLine("eleven");
                                break;

                            case "12":
                                Console.WriteLine("twelve");
                                break;

                            case "13":
                                Console.WriteLine("thirteen");
                                break;

                            case "14":
                                Console.WriteLine("fourteen");
                                break;

                            case "15":
                                Console.WriteLine("fifteen");
                                break;

                            case "16":
                                Console.WriteLine("sixteen");
                                break;

                            case "17":
                                Console.WriteLine("seventeen");
                                break;

                            case "18":
                                Console.WriteLine("eighteen");
                                break;

                            case "19":
                                Console.WriteLine("nineteen");
                                break;

                            case "20":
                                Console.WriteLine("twenty");
                                break;

                            case "30":
                                Console.WriteLine("thirty");
                                break;

                            case "40":
                                Console.WriteLine("forty");
                                break;

                            case "50":
                                Console.WriteLine("fifty");
                                break;

                            case "60":
                                Console.WriteLine("sixty");
                                break;

                            case "70":
                                Console.WriteLine("seventy");
                                break;

                            case "80":
                                Console.WriteLine("eighty");
                                break;

                            case "90":
                                Console.WriteLine("ninety");
                                break;

                        }
                    }
                    else
                    {
                        char firstNumCurrent = number[0];
                        char secondNumCurrent = number[1];
                        string firstNum = null;
                        string secondNum = null;

                        switch (firstNumCurrent)
                        {
                            case '2':
                                firstNum = "twenty";
                                break;

                            case '3':
                                firstNum = "thirty";
                                break;

                            case '4':
                                firstNum = "forty";
                                break;

                            case '5':
                                firstNum = "fifty";
                                break;

                            case '6':
                                firstNum = "sixty";
                                break;

                            case '7':
                                firstNum = "seventy";
                                break;

                            case '8':
                                firstNum = "eighty";
                                break;

                            case '9':
                                firstNum = "ninety";
                                break;

                        }

                        switch (secondNumCurrent)
                        {
                            case '1':
                                secondNum = "one";
                                break;

                            case '2':
                                secondNum = "two";
                                break;

                            case '3':
                                secondNum = "three";
                                break;

                            case '4':
                                secondNum = "four";
                                break;

                            case '5':
                                secondNum = "five";
                                break;

                            case '6':
                                secondNum = "six";
                                break;

                            case '7':
                                secondNum = "seven";
                                break;

                            case '8':
                                secondNum = "eight";
                                break;

                            case '9':
                                secondNum = "nine";
                                break;

                            default:
                                break;
                        }

                        Console.WriteLine($"{firstNum} {secondNum}");
                    }
                }
                else if (number.Length == 3)
                {
                    Console.WriteLine("one hundred");
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
