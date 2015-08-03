
/*
                         Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;


class CalculatingTheFactorialAndPowerFormula
{
    static void Main()
    {
        Console.Write ("Enter n: ");
        int n;

        if(!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Please enter an integer number!!!");
            return;
        }

        Console.Write("Enter x: ");
        int x;

        if (!(int.TryParse(Console.ReadLine(), out x)))
        {
            Console.WriteLine("Please enter an integer number!!!");
            return;
        }

        double sum = 1;
        int factorial = 1;
        int powerXN = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerXN *= x;

            sum += (double)factorial / powerXN; 
        }

        Console.WriteLine("The sum S = {0:F5}", sum);
    }
}