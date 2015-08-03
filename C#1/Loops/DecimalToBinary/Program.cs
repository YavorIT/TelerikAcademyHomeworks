
/*
                    Problem 14. Decimal to Binary Number

        Using loops write a program that converts an integer number to its binary representation.
        The input is entered as long. The output should be a variable of type string.

        Do not use the built-in .NET functionality.
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write ("Enter the integer number: ");
        long number;
        string numberBinary = "";
        long bitPower = 1;

        if (!(long.TryParse(Console.ReadLine(), out number)))
        {
            Console.WriteLine("Please enter a valid integer!!!");
            return;
        }


        if (number == 0)
        {
            Console.WriteLine("The number in decimal is: 0");
            return;
        }

        bitPower <<= 31;

        while (true)
        {
            if (bitPower > number)
            {
                numberBinary = numberBinary + "0";
            }
            if(bitPower <= number)
            {
                numberBinary = numberBinary + "1";    
                number -= bitPower;
            }

            if (number <= 0)
            {
                break;
            }

            bitPower /= 2;
        }

        numberBinary = numberBinary.PadRight(32, '0');

        int count = 0; // Counts where the first bit != 0 is
        for (int i = 0; i < 32; i++)
        {
            if (numberBinary[i] == '0')
            {
                count++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("The number in decimal is: {0}", numberBinary.Substring(count));  // Substring cut's the string on the place of count
                                                                                            //and prints only the ramaining part
    }
}