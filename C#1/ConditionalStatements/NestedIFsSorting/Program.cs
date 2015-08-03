
/*
                       Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.

    Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;

class NestedIFsSorting
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double temp;

        if (firstNumber < secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            if (firstNumber < thirdNumber)
            {
                temp = firstNumber;
                firstNumber = thirdNumber;
                thirdNumber = temp;
            }

            if (secondNumber < thirdNumber)
            {
                temp = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = temp;
            }

        }else if (secondNumber < thirdNumber)
        {
            if (firstNumber < thirdNumber)
            {
                temp = firstNumber;
                firstNumber = thirdNumber;
                thirdNumber = temp;

                temp = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = temp;
            }else
            {
                temp = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = temp;
            }
        }

        Console.WriteLine("{0}  {1}  {2}", firstNumber, secondNumber, thirdNumber);
    }
}
