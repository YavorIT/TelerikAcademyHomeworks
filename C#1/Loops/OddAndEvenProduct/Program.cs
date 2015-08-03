
/*
                            Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write ("Enter your numbers in one line separated by a space: ");
        string input = Console.ReadLine();
        input = input + " ";
        string number = "";
        int isOdd = 1;
        int theNumber;
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                number = number + input[i];
                continue;
            }

            if (!(int.TryParse(number, out theNumber)))
            {
                Console.WriteLine("Please don't use more than one space between the numbers and don't add spaces at the end!");
                return;
            }

            if (isOdd % 2 == 0)
            {
                evenProduct *= theNumber;
            }
            else
            {
                oddProduct *= theNumber;
            }

            isOdd++;

            number = "";
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("The product is: {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd Product: {0}", oddProduct);
            Console.WriteLine("Even Product: {0}", evenProduct);
        }
    }
}