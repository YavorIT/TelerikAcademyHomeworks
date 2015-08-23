
/*
                                            Problem 8. Number as array

    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Numerics;

class NumberAsArray
{
    static BigInteger ParseTheArrayToANumber (BigInteger[] input)
    {
        BigInteger resultNumber = 0;
        for (int i = input.Length - 1, currentMultiplier = 1; i >= 0; i--, currentMultiplier *= 10)
        {
            resultNumber += input[i] * currentMultiplier;
        }
        return resultNumber;
    }

    static BigInteger[] AddTwoIntegers (BigInteger[] first, BigInteger[] second)
    {
        BigInteger[] result = new BigInteger[first.Length];
        BigInteger remainder = 0;

        for (int i = 0, j = first.Length - 1; i < first.Length; i++, j--)
        {
            result[j] += first[i];
        }

        for (int i = 0, j = result.Length - 1; i < second.Length; i++, j--)
        {
            result[j] += second[i];
            if(result[j] > 9)
            {  
                result[j - 1] += result[j] / 10;
                result[j] %= 10;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        string first = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string second = Console.ReadLine();

        BigInteger firstNumber = BigInteger.Parse(first);
        BigInteger secondNumber = BigInteger.Parse(second);

        if(firstNumber < 0 || secondNumber < 0)
        {
            Console.WriteLine("The numbers have to be positive!");
            return;
        }

        BigInteger[] firstNumberArray = new BigInteger[first.Length];
        BigInteger[] secondNumberArray = new BigInteger[second.Length];

        for (int i = 0; i < first.Length; i++)
        {
            firstNumberArray[i] = firstNumber % 10;
            firstNumber /= 10;
        }

        for (int i = 0; i < second.Length; i++)
        {
            secondNumberArray[i] = secondNumber % 10;
            secondNumber /= 10;
        }

        BigInteger resultNumber;
        if (firstNumberArray.Length > secondNumberArray.Length) // Sends the larger array first 
        {
            BigInteger[] result = AddTwoIntegers(firstNumberArray, secondNumberArray);
            resultNumber = ParseTheArrayToANumber(result);
            
        }
        else
        {
           BigInteger[] result = AddTwoIntegers(secondNumberArray, firstNumberArray);
           resultNumber = ParseTheArrayToANumber(result);
        }

        Console.WriteLine("The result of the adding is: {0}", resultNumber);
    }
}