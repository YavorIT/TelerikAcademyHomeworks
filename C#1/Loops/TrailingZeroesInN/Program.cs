
/*
                 Problem 18.* Trailing Zeroes in N!

      Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
      Your program should work well for very big numbers, e.g. n=100000.
*/

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write ("Enter the integer N: ");
        int n = int.Parse(Console.ReadLine());

        int trailingZeroesCount = 0;
        int powerOfFive = 5;

        while(true)
        {

            trailingZeroesCount += n / powerOfFive; // (n / powerOfFive) - The Whole Number After The Division

            if (n / powerOfFive == 0)               
            {
                break;
            }

            powerOfFive *= 5;
        }

        Console.WriteLine("Number of the trailing zeroes: {0}", trailingZeroesCount);
    }
}