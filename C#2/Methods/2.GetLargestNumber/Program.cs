
/*  
                Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/ 

using System;

class GetLargestNumber
{
    static int GetMax (int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }

    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int third = int.Parse(Console.ReadLine());

        int biggest = GetMax(first, second);
        biggest = GetMax(biggest, third);

        Console.WriteLine("The biggest of the three numbers is: {0}", biggest);
    }
}