
/*
                            Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 - 999!");
        Console.Write("Your number: ");
        int userNumber;
        string result = "";

        string[] numbersWords = new string[28]
        {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety",
            "hundred",
        };

        if (!(int.TryParse(Console.ReadLine(), out userNumber)))
        {
            Console.WriteLine("Please enter a valid number!!!");
            return;
        }

        if (userNumber < 0 || userNumber > 999)
        {
            Console.WriteLine("Please enter a number in the interval shown!!!");
            return;
        }

        if (userNumber >= 0 && userNumber <= 19)
        {
            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[1]);
                    break;
                case 3:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[2]);
                    break;
                case 4:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[3]);
                    break;
                case 5:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[4]);
                    break;
                case 6:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[5]);
                    break;
                case 7:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[6]);
                    break;
                case 8:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[7]);
                    break;
                case 9:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[8]);
                    break;
                case 10:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[9]);
                    break;
                case 11:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[10]);
                    break;
                case 12:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[11]);
                    break;
                case 13:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[12]);
                    break;
                case 14:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[13]);
                    break;
                case 15:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[14]);
                    break;
                case 16:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[15]);
                    break;
                case 17:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[16]);
                    break;
                case 18:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[17]);
                    break;
                case 19:
                    Console.WriteLine("{0} - {1}", userNumber, numbersWords[18]);
                    break;
            }
            return;
        }else if (userNumber >= 20 && userNumber <= 99)
        {
            for (int i = 2; i <= 9; i++)
            {
                if (userNumber % 100 >= i * 10 && userNumber % 100 < (i + 1) * 10)
                {
                    result = numbersWords[i + 17];
                    break;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (userNumber % 10 == i + 1)
                {
                    result = result + " " + numbersWords[i];
                    break;
                }
            }
        }else if(userNumber >= 100)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (userNumber % 1000 >= i * 100 && userNumber % 1000 < (i + 1) * 100)
                {
                    result = numbersWords[i - 1] + " " + numbersWords [27];
                    break;
                }
            }
            for (int i = 2; i <= 9; i++)
            {
                if (userNumber % 100 >= i * 10 && userNumber % 100 < (i + 1) * 10)
                {
                    result = result + " and " + numbersWords[i + 17];
                    break;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (userNumber % 10 == i + 1)
                {
                    result = result + " " + numbersWords[i];
                    break;
                }
            }
        }

        Console.WriteLine("{0} - {1}", userNumber, result);
    }
}