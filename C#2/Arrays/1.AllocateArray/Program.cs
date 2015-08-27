
/*
                            Problem 1. Allocate array

     Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
     Print the obtained array on the console.
*/

using System;

class AllocateArray
{
    static void Main()
    {
        int[] indexTimesFive = new int[20];

        for (int i = 0; i < 20; i++)
        {
            indexTimesFive[i] = i * 5;
        }

        for (int i = 0; i < indexTimesFive.Length; i++)
        {
            Console.WriteLine("{0} - {1}", i, indexTimesFive[i]);
        }
    }
}