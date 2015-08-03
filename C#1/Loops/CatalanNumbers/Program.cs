
/*
                          Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: 

    n >= 0          (2n)!/ (n + 1)!n!

    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write ("Enter a number n [0;100]: ");
        int n;

        if (!(int.TryParse(Console.ReadLine(), out n)) || n < 0 || n > 100)
        {
            Console.WriteLine("Please enter a valid number!");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("The Catalan number is 1");
            return;
        }

        BigInteger nFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger nTimesTwoFactorial = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            if (i <= n)
            {
                nFactorial *= i;
            }

            if (i <= n + 1)
            {
                nPlusOneFactorial *= i;
            }

            nTimesTwoFactorial *= i;
        }

        Console.WriteLine("The {0} Catalan number is: {1}", n, nTimesTwoFactorial / (nPlusOneFactorial * nFactorial));
    }
}