
/*
                          Problem 7. One system to any other

    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

using System;

class OneSystemtoAnother
{
    static void Main()
    {
        Console.WriteLine("Enter the number system you want to convert from (>= 2 and <= 37): ");
        int baseS = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number system you want to convert to (>= 2 and <= 16): ");
        int baseD = int.Parse(Console.ReadLine());

        if(baseS < 2 || baseS > 37 || baseD < 2 || baseD > 16)
        {
            Console.WriteLine("Invalid input of the bases!!!");
            return;
        }

        Console.WriteLine("Enter the number to convert: ");
        string convert = Console.ReadLine();
        convert = convert.ToUpper();

        long result = 0;
        long sPower = 1;

        // first converting the number to decimal
        for (int i = convert.Length - 1; i >= 0; i--)
        {
            switch (convert[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    result += ((int)(convert[i]) - 48) * sPower; // Withdrawing 48 Because in the ASCII table the number 0-9 are 48-57
                    break;                                         // And (int)convert[i] return the ASCII number of the character;           
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    result += ((int)(convert[i]) - 55) * sPower; // Withdrawing 55 Because in the ASCII table the letters A - Z are 65-90
                    break;                                         // And (int)convert[i] return the ASCII number of the character; 
            }
            sPower *= baseS;
        }

        //now convert the number to d base system

        string dBaseNumber = string.Empty;
        char[] dBaseNumbers = new char[36]
        {
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'
        };

        while (result != 0)
        {
            dBaseNumber = dBaseNumbers[result % baseD] + dBaseNumber;
            result /= baseD;
        }

        Console.WriteLine(dBaseNumber);
    }
}