
/*
              Problem 3. Decimal to hexadecimal

    Write a program to convert decimal numbers to their hexadecimal representation.
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