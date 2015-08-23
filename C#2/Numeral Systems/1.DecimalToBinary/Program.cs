
/*
             Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.
*/

using System;

class DecimalToBinary
{
    static void PrintArray (int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write("{0}", Array[i]);
            if(i % 4 == 0)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter the integer: ");
        int number;

        if(!(int.TryParse(Console.ReadLine(), out number)))
        {
            Console.WriteLine("Invalid input!!!");
            return;
        }

        int[] result = new int[32];
        int i = 31;

        while (number != 0)
        {
            result[i] = number % 2;
            number /= 2;
            i--;
        }

        PrintArray(result);
    }
}