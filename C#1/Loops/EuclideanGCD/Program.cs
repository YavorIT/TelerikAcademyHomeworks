
/*
                            Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
*/

using System;

class EuclideanGCD
{
    static void Main()
    {
        Console.Write ("Enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int firstRemainder = 0;
        int remainder = 0;

        if (firstNumber > secondNumber)
        {
            firstRemainder = firstNumber % secondNumber;

            if (firstRemainder == 0)
            {
                Console.WriteLine("Numbers are equal so the GCD is: {0}", firstNumber);
                return;
            }

            remainder = secondNumber % firstRemainder;
            while (true)
            {

                if (remainder == 0)
                {
                    break;
                }
                firstRemainder = remainder;
                remainder = firstRemainder % remainder;
            }
        }
        else
        {
            firstRemainder = secondNumber % firstNumber;

            if (firstRemainder == 0)
            {
                Console.WriteLine("Numbers are equal so the GCD is: {0}", firstNumber);
                return;
            }

            remainder = firstNumber % firstRemainder;
            while (true)
            {

                if (remainder == 0)
                {
                    break;
                }
                firstRemainder = remainder;
                remainder = firstRemainder % remainder;
            }
        }

        Console.WriteLine("The GCD is: {0}", firstRemainder);
    }
}