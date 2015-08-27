
/*
                       Problem 19.* Permutations of set

    Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
*/

// I have used the backtracking algorithm - I saw the algorithm in the internet!

using System;

class PermutationsOfSet
{
    static void Permutations(int[] input, int currentLoop, int numbersCount)
    {
        if (currentLoop == numbersCount)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && i < input.Length - 1)
                {
                    Console.Write("{{{0}", input[i]);
                }
                else if (i == 0 && i == input.Length - 1)
                {
                    Console.Write("{{{0}}}", input[i]);
                }
                else if (i != 0 && i != input.Length - 1)
                {
                    Console.Write(", {0}", input[i]);
                }else if (i != 0 && i == input.Length - 1)
                {
                    Console.Write(", {0}}}", input[i]);
                }
            }
            Console.WriteLine();
            return;
        }

        for (int j = currentLoop; j < numbersCount; j++)
        {
            int temp = input[currentLoop];
            input[currentLoop] = input[j];
            input[j] = temp;

            Permutations(input, currentLoop + 1, numbersCount);

            temp = input[currentLoop];
            input[currentLoop] = input[j];
            input[j] = temp;
        }
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbersToN = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbersToN[i] = (i + 1);
        }

        Permutations(numbersToN, 0, n);
        
    }
}