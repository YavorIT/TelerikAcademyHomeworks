
/*
                            Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
*/

using System;

class EuclideanGCD
{
    static int GCD (int first, int second)
    {
        int biggerNumber;
        int nextNumber;
        int remainder;
        int temp;
        
        if(first > second)
        {
            biggerNumber = first;
            nextNumber = second;
        }
        else
        {
            biggerNumber = second;
            nextNumber = first;
        }

        remainder = biggerNumber % nextNumber;
        while(remainder != 0)
        {
            temp = nextNumber;
            nextNumber = biggerNumber % nextNumber;
            biggerNumber = temp;
            remainder = biggerNumber % nextNumber;
        }

        return nextNumber;
    }
    static void Main()
    {
        Console.Write ("Enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The GCD is: {0}", GCD (firstNumber, secondNumber));
    }
}