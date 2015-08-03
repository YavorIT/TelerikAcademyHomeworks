
/*
                      Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double biggestNumber = firstNumber;

        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }

        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }

        if (biggestNumber < fourthNumber)
        {
            biggestNumber = fourthNumber;
        }

        if (biggestNumber < fifthNumber)
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}
