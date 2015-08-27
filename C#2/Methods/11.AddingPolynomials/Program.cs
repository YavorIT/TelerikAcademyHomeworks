
/*
             Problem 11. Adding polynomials

    Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.

                Example:

    x^2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}
*/

/* This program is combined with the next

                Problem 12. Subtracting polynomials

         Extend the previous program to support also subtraction and multiplication of polynomials.
 */

using System;

class MathOperationsWithPolynomials
{
    static void Add (int[] firstPolynomial, int[] secondPolynomial, int[] result)
    {
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            result[i] = firstPolynomial[i];
        }

        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            result[i] += secondPolynomial[i];
        }
    }

    static void Subtract (int[] firstPolynomial, int[] secondPolynomial, int[] result)
    {
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            result[i] = firstPolynomial[i];
        }

        for (int i = 0; i < secondPolynomial.Length; i++)
        {
            result[i] -= secondPolynomial[i];
        }
    }

    static void Multiply (int[] firstPolynomial, int[] secondPolynomial, int[] result)
    {
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                result[i + j] += firstPolynomial[i] * secondPolynomial[j];
            }
        }
    }

    static void PrintPolynomial (int[] input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if(input[i] >= 0 && i != input.Length - 1)
            {
                Console.Write("+ ");
            }
            if (i > 1)
            {
                Console.Write("{0}x^{1} ", input[i], i);
            }
            else if (i == 1)
            {
                Console.Write("{0}x ", input[i]);
            }
            else
            {
                Console.Write("{0}", input[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // entering the first polynomial
        Console.Write("Enter the degree of the first polynom: ");
        int firstPolynomialDegree = int.Parse(Console.ReadLine());
        
        int[] coeffFirstPolynomial = new int[firstPolynomialDegree + 1];
        Console.WriteLine("\nEnter the coefficients of the first polynom: ");
        for (int i = firstPolynomialDegree; i >= 0; i--)
        {
            Console.Write("Coefficient in front of {0} degree: ", i);
            coeffFirstPolynomial[i] = int.Parse(Console.ReadLine());
        }


        // entering the second polynomial
        Console.Write("\nEnter the degree of the second polynomial: ");
        int secondPolynomialDegree = int.Parse(Console.ReadLine());

        int[] coeffSecondPolynomial = new int[secondPolynomialDegree + 1];
        Console.WriteLine("\nEnter the coefficients of the second polynomial: ");
        for (int i = secondPolynomialDegree; i >= 0; i--)
        {
            Console.Write("Coefficient in front of {0} degree: ", i);
            coeffSecondPolynomial[i] = int.Parse(Console.ReadLine());
        }


        // checking which polynomial is longer so that the result is big enough
        int biggerPolynomialDegree;
        if (firstPolynomialDegree > secondPolynomialDegree)
        {
            biggerPolynomialDegree = firstPolynomialDegree;
        }
        else
        {
            biggerPolynomialDegree = secondPolynomialDegree;
        }

        int[] result = new int[biggerPolynomialDegree + 1];



        Add(coeffFirstPolynomial, coeffSecondPolynomial, result);
        Console.WriteLine("\nResult after adding the polynomials:");
        PrintPolynomial(result);



        Subtract(coeffFirstPolynomial, coeffSecondPolynomial, result);
        Console.WriteLine("\nResult after subtracting the polynomials:");
        PrintPolynomial(result);



        int[] resultMultiply = new int[coeffFirstPolynomial.Length + coeffSecondPolynomial.Length - 1];
        Multiply(coeffFirstPolynomial, coeffSecondPolynomial, resultMultiply);
        Console.WriteLine("\nResult after multyplying the polynomials:");
        PrintPolynomial(resultMultiply);
        
    }
}