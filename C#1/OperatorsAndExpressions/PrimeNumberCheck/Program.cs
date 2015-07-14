
/*
						Problem 8. Prime Number Check

	Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
	(i.e. it is divisible without remainder only to itself and 1).
	Note: You should check if the number is positive
*/

using System;

class PrimeNumberCheck
{
	public static void Main ()
	{
		Console.Write ("Enter a number from 0 to 100: ");
		int number = int.Parse (Console.ReadLine ());
		bool isZeroToHundred = (number > 0) && (number <= 100);
		bool isComposite = false;
		if (number == 1)
			isComposite = true;
		
		if (isZeroToHundred) 
		{
			for (int i = 2; i <= number/2; i++)
			{
				if ((number % i) == 0)
				{
					isComposite = true;
					break;
				}
			}
			 Console.WriteLine ("The number is Prime: {0}", !isComposite);
		} else 
		{
			Console.WriteLine ("Please enter a number positive number less than 100!");
		}
	}
}