
/*
                                 Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers
    from 1 to n, on a single line, separated by a space.
*/

using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.Write ("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.Write("{0} ", i + 1);
        }
        Console.WriteLine();
    }
}
