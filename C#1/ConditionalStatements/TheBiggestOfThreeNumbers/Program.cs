
/*
            Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.
*/

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double biggestNumber = firstNumber;

        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}