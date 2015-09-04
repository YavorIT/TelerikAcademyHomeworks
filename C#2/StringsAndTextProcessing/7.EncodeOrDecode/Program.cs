
/*
                                    Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.

    The encoding/decoding is done by performing XOR (exclusive or)
    operation over the first letter of the string with the first of the key,
    the second – with the second, etc. 

    When the last key character is reached,
    the next is the first.
*/

using System;
using System.Text;

class EncodeOrDecode
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the encryption key: ");
        string encryptionKey = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        for (int i = 0, j = 0; i < input.Length; i++, j++)
        {
           if(j == encryptionKey.Length)
            {
                j = 0;
            }

            result.Append((char)(input[i] ^ encryptionKey[j]));
        }

        Console.WriteLine(result);
    }
}