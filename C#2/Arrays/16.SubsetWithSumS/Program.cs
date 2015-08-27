
/*  
                     Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.
*/

using System;
using System.Text.RegularExpressions;

class SubsetWithSumS
{

    static bool NestedLoops (int[] input, int currentLoop, int userSum, int currentSum)
    {
        if (currentLoop == input.Length)
        {
            return false;
        }
        bool returnValue = false;
        for (int i = currentLoop; i < input.Length; i++)
        {
            if (input[i] + currentSum == userSum)
            {
                return true;
            }
            else
            {
                returnValue = NestedLoops(input, currentLoop + 1, userSum, currentSum + input[i]);
                if(returnValue)
                {
                    break;
                }
            }
        }
        return returnValue;
    }

    static void Main()
    {
        Console.WriteLine("Enter the array (1, 2, ..., n): ");
        string[] input = Regex.Split(Console.ReadLine(), ", ");

        int[] numbers = new int[input.Length]; 

        for (int i = 0; i < input.Length; i++)
        {
            if (!(int.TryParse(input[i], out numbers[i])))
            {
                Console.WriteLine("Please enter the array in the correct format!!!");
                return;
            }
        }

        Console.Write ("Enter the sum you want to find: ");
        int sum = int.Parse(Console.ReadLine());

        bool yesOrNo;
        yesOrNo = NestedLoops(numbers, 0, sum, 0);

        if (yesOrNo)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}