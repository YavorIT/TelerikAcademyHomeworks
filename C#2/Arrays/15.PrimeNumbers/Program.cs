
/*
                      Problem 15. Prime numbers

    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write ("Enter an integer to stop: ");
        int maxNumbers = int.Parse(Console.ReadLine());
        bool[] isComposite = new bool[maxNumbers + 1];

        for (int i = 2; i * i <= maxNumbers; i++)
        {
            if (!isComposite[i])
            {
                for (int j = i * i; j <= maxNumbers; j = j + i)
                {
                    isComposite[j] = true;
                }
            }
        }

        for (int i = 2; i < maxNumbers; i++)
        {
            if (!isComposite[i])
            {
                if (i == 2)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write(", {0}", i);
                }
            }
        }
        Console.WriteLine();
    }
}
