
/*
                                 Problem 9.* Binary floating-point

    Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
*/

using System;

class BinaryFloatingPoint
{

    static void Main()
    {
        Console.Write("Enter the floating point number: ");
        float number = float.Parse(Console.ReadLine());

        byte[] binary = BitConverter.GetBytes(number);

        string result = string.Empty;

        for (int i = 0; i < binary.Length; i++)
        {
            result = Convert.ToString(binary[i], 2) + result;
        }

        Console.WriteLine("Binary representation: {0}\n", result);

        result = result.PadRight(32, '0');
        Console.WriteLine("Sign: {0}", result[0]);
        Console.Write("Exponent: ");
        for (int i = 1; i < 9; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine("\nMantissa: {0}", result.Substring(9));
    }
}