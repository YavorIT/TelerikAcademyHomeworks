
/*
                     Problem 21.* Combinations of set

    Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
*/

using System;
using System.Collections.Generic;

class CombinationsOfSet
{
    static void Combinations(List<int> input, int n, int k, int currentLoop, int lastNumber)
    {
        if (currentLoop == k)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (i == 0 && i < input.Count - 1)
                {
                    Console.Write("{{{0}", input[i]);
                }
                else if (i == 0 && i == input.Count - 1)
                {
                    Console.Write("{{{0}}}", input[i]);
                }
                else if (i != 0 && i != input.Count - 1)
                {
                    Console.Write(", {0}", input[i]);
                }
                else if (i != 0 && i == input.Count - 1)
                {
                    Console.Write(", {0}}}", input[i]);
                }
            }
            Console.WriteLine();
            return;
        }

        for (int i = lastNumber + 1; i <= n; i++)
        {
            input.Add(i);
            Combinations(input, n, k, currentLoop + 1, i);
            input.RemoveAt(input.Count - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("\tNOTE: THE NUMBERS YOU WILL ENTER MUST BE GREATER THAN ZERO!");
        Console.Write("Enter the number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the number K: ");
        int k = int.Parse(Console.ReadLine());

        if(n <= 0 || k <= 0)
        {
            Console.WriteLine("Read the note and try again!");
            return;
        }

        int[] numbersToN = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbersToN[i] = i + 1;
        }
        List<int> print = new List<int>();

        Combinations(print, n, k, 0, 0);
    }
}