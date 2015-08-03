
/*
                                     Problem 12.* Zero Subset

    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem.
*/


using System;

class ZeroSubset
{
    static void Main()
    {
        int[] numbers = new int[5];
        string equalsZero = " = 0\n";
        string result = "";
        string[] numbersText = new string[5];
      
        for (int i = 0; i < 5; i++)
        {
            Console.Write ("Enter the {0} integer: ", i);
            numbersText[i] = Console.ReadLine();

            if (!(int.TryParse(numbersText[i], out numbers[i])))
            {
                Console.WriteLine("Invalid number!!!");
                return;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    result = result + numbersText[i] + " + " + numbersText[j] + equalsZero;
                }
            }
        }

        for (int i = 0, k = 1; k < 5; i++, k++)
        {
            for (int j = k + 1; j < 5; j++)
            {
                if ((numbers[i] + numbers[k]) + numbers[j] == 0)
                {
                    result = result + numbersText[i] + " + " + numbersText[k] + " + " + numbersText[j] + equalsZero;
                }
            }
        }

        for (int i = 0, k = 1, m = 2; m < 5; i++, k++, m++)
        {
            for (int j = m + 1; j < 5; j++)
            {
                if ((numbers[i] + numbers[k] + numbers[m]) + numbers[j] == 0)
                {
                    result = result + numbersText[i] + " + " + numbersText[k] + " + " + numbersText[m] + " + " + numbersText[j] + equalsZero;
                }
            }
        }

        for (int i = 0, k = 2; k < 5; i++, k++)
        {
            for (int j = k + 1; j < 5; j++)
            {
                if ((numbers[i] + numbers[k]) + numbers[j] == 0)
                {
                    result = result + numbersText[i] + " + " + numbersText[k] + " + " + numbersText[j] + equalsZero;
                }
            }
        }

        int temp = 0;
        for (int i = 0; i < 5; i++)
        {
            temp += numbers[i];
        }

        if (temp == 0)
        {
            result = result + numbersText[0] + " + " + numbersText[1] + " + " + numbersText[2] + " + " + numbersText[3] + " + " + numbersText[4] + equalsZero;
        }

        if (result == "")
        {
            Console.WriteLine("No zero subset!");
            return;
        }

        Console.WriteLine(result);
    }
}
