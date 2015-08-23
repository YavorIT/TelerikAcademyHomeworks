
/*
            Problem 6. Binary to hexadecimal

    Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter the number in binary (without spaces): ");
        string binary = Console.ReadLine().PadLeft(32, '0');

        string hexNumber = string.Empty;

        while (binary.Length != 0)
        {
            string fourBits = binary.Substring(binary.Length - 4);
            switch (fourBits)
            {
                case "0000":
                    hexNumber += "0";
                    break;
                case "0001":
                    hexNumber += "1";
                    break;
                case "0010":
                    hexNumber += "2";
                    break;
                case "0011":
                    hexNumber += "3";
                    break;
                case "0100":
                    hexNumber += "4";
                    break;
                case "0101":
                    hexNumber += "5";
                    break;
                case "0110":
                    hexNumber += "6";
                    break;
                case "0111":
                    hexNumber += "7";
                    break;
                case "1000":
                    hexNumber += "8";
                    break;
                case "1001":
                    hexNumber += "9";
                    break;
                case "1010":
                    hexNumber += "A";
                    break;
                case "1011":
                    hexNumber += "B";
                    break;
                case "1100":
                    hexNumber += "C";
                    break;
                case "1101":
                    hexNumber += "D";
                    break;
                case "1110":
                    hexNumber += "E";
                    break;
                case "1111":
                    hexNumber += "F";
                    break;
            }

            binary = binary.Remove(binary.Length - 4, 4);
        }

        hexNumber = hexNumber.TrimEnd('0'); // Removes the trailing sequence of zeroes
        Console.WriteLine(hexNumber);
    }
}