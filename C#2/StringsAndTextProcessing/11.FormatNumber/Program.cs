
/*
                            Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number,
    percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
*/

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        string number = Console.ReadLine();

        Console.WriteLine("{0,-20}: {1,15}","Decimal", number);
        Console.WriteLine("{0,-20}: {1,15:X4}", "Hexadecimal", (int)double.Parse(number));
        Console.WriteLine("{0,-20}: {1,15:P}", "Percentage", double.Parse(number));
        Console.WriteLine("{0,-20}: {1,15:e}", "Scientific notation", double.Parse(number));
    }
}