
/*
			Problem 6. Four-Digit Number

	Write a program that takes as input a four-digit number in format abcd (e.g. 2011) 
	and performs the following:
	
	Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
	Prints on the console the number in reversed order: dcba (in our example 1102).
	Puts the last digit in the first position: dabc (in our example 1201).
	Exchanges the second and the third digits: acbd (in our example 2101).
	The number has always exactly 4 digits and cannot start with 0.
*/

using System;

class FourDigitNumber
{
	public static void Main ()
	{
		Console.Write ("Enter the four-digit number: ");
		int number = int.Parse (Console.ReadLine ()); 
		int[] arrayNumber = new int [4];

			for (int i = 3; i >= 0; i--) {
				arrayNumber [i] = number % 10;
				number /= 10;
			}
		if (arrayNumber [0] == 0) {
			Console.WriteLine ("The number can't start with a \"0\"!");
		} else {
			int sum = 0;
			for (int i = 0; i < 4; i++) {
				sum += arrayNumber [i];
			}

			Console.WriteLine ("The sum of the number's digits is: {0}", sum);

			Console.Write ("The number in reversed order is: ");

			for (int i = 3; i >= 0; i--) {
				Console.Write (arrayNumber [i]);
			}

			int temp;
			temp = arrayNumber [3];
			arrayNumber [3] = arrayNumber [2];
			arrayNumber [2] = arrayNumber [1];
			arrayNumber [1] = arrayNumber [0];
			arrayNumber [0] = temp;

			Console.WriteLine ();
			Console.Write ("Last digit is first: ");
			for (int i = 0; i < 4; i++) {
				Console.Write ("{0}", arrayNumber [i]);
			}


			temp = arrayNumber [0];
			arrayNumber [0] = arrayNumber [1];
			arrayNumber [1] = arrayNumber [2];
			arrayNumber [2] = arrayNumber [3];
			arrayNumber [3] = temp;

			temp = arrayNumber [1];
			arrayNumber [1] = arrayNumber [2];
			arrayNumber [2] = temp;

			Console.WriteLine ();
			Console.Write ("Changed 2nd and 3rd digits: ");
			for (int i = 0; i < 4; i++) {
				Console.Write ("{0}", arrayNumber [i]);
			}
		}
	}
}