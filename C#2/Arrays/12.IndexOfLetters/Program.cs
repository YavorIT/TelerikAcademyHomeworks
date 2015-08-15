
/*
                     Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];
        int j = 0;
        for (int i = 65; i <= 90; i++, j++)
        {
            letters[j] = (char)i;
        }

        string word = Console.ReadLine();
        word = word.ToUpper();

        for (int i = 0; i < letters.Length; i++)
        {
            for (int k = 0; k < word.Length; k++)
            {
                if(word[k] == letters[i])
                {
                    Console.WriteLine("{0} - {1}", word[k], i);
                }
            }
        }
    }
}