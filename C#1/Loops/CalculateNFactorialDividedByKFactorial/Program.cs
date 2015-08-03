
/*  
                    Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
*/

using System;

class CalculateNFactorialDividedByKFactorial
{
    static void Main()
    {
        Console.Write ("Enter an integer k [1;100]: ");
        int k;

        if(!(int.TryParse(Console.ReadLine(), out k)) || k < 1 || k > 100)
        {
            Console.WriteLine("Please enter a valid number!");
        }

        Console.Write("Enter an integer n [k;100]: ");
        int n;

        if (!(int.TryParse(Console.ReadLine(), out n)) || n < k || n > 100)
        {
            Console.WriteLine("Please enter a valid number!");
        }

        int kFactorial = 1;
        int nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kFactorial *= i;
            }

            nFactorial *= i;
        }

        double result = (double)nFactorial / kFactorial;

        Console.WriteLine("N!/K! = {0}", result);
    }
}