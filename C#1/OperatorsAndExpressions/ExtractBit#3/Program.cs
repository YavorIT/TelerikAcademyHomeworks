
/*
								Problem 11. Bitwise: Extract Bit #3

	Using bitwise operators, write an expression for finding the value of the bit #3 
	of a given unsigned integer.
	The bits are counted from right to left, starting from bit #0.
	The result of the expression should be either 1 or 0.
*/

using System;

class ExtractBit3
{
	public static void Main ()
	{
		Console.Write ("Enter a positive integer: ");
		int number = int.Parse (Console.ReadLine ());

		int mask = 1;
		mask <<= 3;


		int isTrue = (mask & number) >> 3;

		Console.WriteLine ("The third bit of the number is: {0}", isTrue);
	}
}