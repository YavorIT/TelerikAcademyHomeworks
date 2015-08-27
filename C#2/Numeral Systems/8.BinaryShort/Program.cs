
/*
    
*/

using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter the short number: ");
        short number;

        if(!(short.TryParse(Console.ReadLine(), out number)))
        {
            Console.WriteLine("The number does not fitt in the short format!");
            Console.WriteLine("It must be [-32768 ; 32767]!");
            return;
        }

        string result = string.Empty;

        if (number >= 0)
        {
            result = Convert.ToString(number, 2);
        }
        else
        {
            number = (short)(-32768 - number);
            result = Convert.ToString(number, 2);
        }
        result = result.PadLeft(16, '0');
        Console.WriteLine(result);
    }
}