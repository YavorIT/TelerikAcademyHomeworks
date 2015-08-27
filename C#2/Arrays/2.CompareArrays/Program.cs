
/*
                         Problem 2. Compare arrays
    
    Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main()
    {
        int[] firstArray = new int[10];
        int[] secondArray = new int[10];

        Console.WriteLine("Enter the elements of the first array: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write ("Array[{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write ("Array[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("Arrays are not equal!");
                return;
            }
        }
        Console.WriteLine("Arrays are equal!");
    }
}