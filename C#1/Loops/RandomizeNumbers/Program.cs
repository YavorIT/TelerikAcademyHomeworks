
/*
    
*/

using System;
using System.Collections.Generic;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write ("Enter the integer n: ");
        int n;

        if (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Enter a valid integer!");
            return;
        }

        List<int> numbers = new List<int>();


        Random randomNumber = new Random();
        int random;
        while(true)
        {
            random = randomNumber.Next(1, n + 1);
            if (numbers.Contains(random))
            {
                continue;
            }
            else
            {
                numbers.Add(random);
                Console.WriteLine("{0} ", random);
            }

           if (numbers.Count == n)
            {
                break;
            }
        }
    }
}