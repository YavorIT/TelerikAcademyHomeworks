
/*
                     Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main()
    {
            char[] firstArray = new char[10];
            char[] secondArray = new char[10];

            Console.WriteLine("Enter the elements of the first array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Array[{0}] = ", i);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the second array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Array[{0}] = ", i);
                secondArray[i] = char.Parse(Console.ReadLine());
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