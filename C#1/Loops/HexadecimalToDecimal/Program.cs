
/*
                     Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.

    Do not use the built-in .NET functionality.
*/

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter the number in hexadecimal system: ");
        string hexNumber = Console.ReadLine();

        long result = 0;
        long hexPower = 1;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    result += ((int)(hexNumber[i]) - 48) * hexPower; // Withdrawing 48 Because in the ASCII table the number 0-9 are 48-57
                    break;                                           // And (int)hexNumber[i] return the ASCII number of the character;           
                case 'A':
                case 'a':
                    result += 10 * hexPower;
                    break;
                case 'B':
                case 'b':
                    result += 11 * hexPower;
                    break;
                case 'C':
                case 'c':
                    result += 12 * hexPower;
                    break;
                case 'D':
                case 'd':
                    result += 13 * hexPower;
                    break;
                case 'E':
                case 'e':
                    result += 14 * hexPower;
                    break;
                case 'F':
                case 'f':
                    result += 15 * hexPower;
                    break;
            }
            hexPower *= 16;
        }

        Console.WriteLine("The Number in decimal is: {0}", result);
    }
}