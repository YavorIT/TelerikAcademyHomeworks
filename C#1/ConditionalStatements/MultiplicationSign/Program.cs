
/*
                                    Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write ("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        int negativeNumbers = 0;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The result is: 0");
            return;
        }
        else
        {
            if (firstNumber < 0)
            {
                negativeNumbers++;
            }
            if (secondNumber < 0)
            {
                negativeNumbers++;
            }
            if (thirdNumber < 0)
            {
                negativeNumbers++;
            }
        }

        if (negativeNumbers % 2 == 0)
        {
            Console.WriteLine("The result is: \"+\"");
        }
        else
        {
            Console.WriteLine("The result is: \"-\"");
        }
    }
}