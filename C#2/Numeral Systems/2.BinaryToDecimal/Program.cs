
/*
              Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {

        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();

        int bitPower = 1;
        int result = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
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