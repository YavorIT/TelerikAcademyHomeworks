
/*
                        Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.

    Do not use the built-in .NET functionality.
*/

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter the decimal integer: ");
        long decNumber = long.Parse(Console.ReadLine());

        string hexNumber = "";

        while (true)
        {
            switch (decNumber % 16)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    hexNumber = (decNumber % 16).ToString() + hexNumber;
                    break;
                case 10:
                    hexNumber = "A" + hexNumber;
                    break;
                case 11:
                    hexNumber = "B" + hexNumber;
                    break;
                case 12:
                    hexNumber = "C" + hexNumber;
                    break;
                case 13:
                    hexNumber = "D" + hexNumber;
                    break;
                case 14:
                    hexNumber = "E" + hexNumber;
                    break;
                case 15:
                    hexNumber = "F" + hexNumber;
                    break;
            }

            if (decNumber == 0)
            {
                break;
            }

            decNumber /= 16;
        }

        Console.WriteLine("The number in hexadecimal is: {0}", hexNumber);
    }
}