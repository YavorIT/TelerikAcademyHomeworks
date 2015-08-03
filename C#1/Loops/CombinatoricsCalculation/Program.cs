
/*
                                          Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements
    (also known as the number of combinations) is calculated by the following formula: 
    formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.

    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class CombinatoricsCalculation
{
    static void Main()
    {
        Console.Write ("Enter a positive integer k [1;100]: ");
        uint k;

        if (!(uint.TryParse(Console.ReadLine(), out k)) || k > 100 || k < 1)
        {
            Console.WriteLine("Please enter a valid number!");
            return;
        }

        Console.Write("Enter a positive integer n [k;100]: ");
        uint n;

        if (!(uint.TryParse(Console.ReadLine(), out n)) || n > 100 || n < k)
        {
            Console.WriteLine("Please enter a valid number!");
            return;
        }

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger differenceFactorial = 1;

        for (uint i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kFactorial *= i;
            }

            if (i <= n - k)
            {
                differenceFactorial *= i;
            }

            nFactorial *= i;
        }

        Console.WriteLine("The result is: {0}", nFactorial/(kFactorial * differenceFactorial));
    }
}