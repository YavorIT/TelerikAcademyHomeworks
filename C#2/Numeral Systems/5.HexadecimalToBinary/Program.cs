
/*
                  Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter the number in Hexadecimal system: ");
        string hexNumber = Console.ReadLine();
        hexNumber = hexNumber.ToUpper();

        string binary = string.Empty;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch(hexNumber[i])
            {
                case '0':
                    binary += "0000 ";
                    break;
                case '1':
                    binary += "0001 ";
                    break;
                case '2':
                    binary += "0010 ";
                    break;
                case '3':
                    binary += "0011 ";
                    break;
                case '4':
                    binary += "0100 ";
                    break;
                case '5':
                    binary += "0101 ";
                    break;
                case '6':
                    binary += "0110 ";
                    break;
                case '7':
                    binary += "0111 ";
                    break;
                case '8':
                    binary += "1000 ";
                    break;
                case '9':
                    binary += "1001 ";
                    break;
                case 'A':
                    binary += "1010 ";
                    break;
                case 'B':
                    binary += "1011 ";
                    break;
                case 'C':
                    binary += "1100 ";
                    break;
                case 'D':
                    binary += "1101 ";
                    break;
                case 'E':
                    binary += "1110 ";
                    break;
                case 'F':
                    binary += "1111 ";
                    break;
            }
        }

        Console.WriteLine("The number in binary is:\n{0}", binary);
    }
}