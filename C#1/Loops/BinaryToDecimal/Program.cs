
/*
                  Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write ("Enter a binary number: ");
        string binary = Console.ReadLine();

        int bitPower = 1;
        int result = 0;

        for (int i = binary.Length - 1; i >= 0 ; i--)
        {
            if (binary[i] != '0')
            {
                result += bitPower;
            }

            bitPower *= 2;
        }
        
        Console.WriteLine("The number in decimal: {0}", result);
    }
}