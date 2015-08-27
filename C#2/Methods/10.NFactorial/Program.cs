
/*      
                         Problem 10. N Factorial

    Write a program to calculate n! for each n in the range [1..100].
    Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial (int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static void PrintArray (BigInteger[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine("{0}", input[i]);  
        }
    }

    static void Main()
    {
        BigInteger[] factorials = new BigInteger[100];
        for (int i = 1; i < 100; i++)
        {
            BigInteger factorial = Factorial(i);
            factorials[i] = factorial;
        }

        PrintArray(factorials);
    }
}