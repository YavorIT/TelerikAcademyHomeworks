
/*
                             Problem 17.* Subset K with sum S

    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
*/

using System;

class SubsetKWithSumS
{
    static bool NestedKLoops (int[] input, int k, int currentLoop, int currSum, int userSum)
    {
        if(currentLoop == k)
        {
            return false;
        }

        bool returnValue = false;

        for (int i = currentLoop; i < input.Length; i++)
        {
            if (currSum + input[i] == userSum)
            {
                return true;
            }
            else
            {
                returnValue = NestedKLoops(input, k, currentLoop + 1, currSum + input[i], userSum);
                if (returnValue)
                {
                    break;
                }
            }
        }

        return returnValue;
    }

    static void Main()
    {
        Console.Write ("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        if(k > n)
        {
            Console.WriteLine("K must be smaller than or equal to N!!!");
            return;
        }

        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        int[] numbers = new int [n];

        for (int i = 0; i < n; i++)
        {
            Console.Write ("\nEnter the {0} element of the array: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool yesOrNo = NestedKLoops(numbers, k, 0, 0, s);

        if(yesOrNo)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}