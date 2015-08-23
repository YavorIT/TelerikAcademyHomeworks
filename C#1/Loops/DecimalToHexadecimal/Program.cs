
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
        char[] hexNumbers = new char[16]
        {
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            'A',
            'B',
            'C',
            'D',
            'E',
            'F'
        };
            
        while(decNumber != 0)
        {
            hexNumber = hexNumbers[decNumber % 16] + hexNumber;
            decNumber /= 16;
        }

        Console.WriteLine("The number in hexadecimal is: {0}", hexNumber);
    }
}