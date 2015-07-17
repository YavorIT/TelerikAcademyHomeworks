
/*
 					 Problem 14. Modify a Bit at Given Position

	We are given an integer number n, a bit value v (v=0 or 1) and a position p.
	Write a sequence of operators (a few lines of C# code) that modifies n
	to hold the value v at the position p from the binary representation of n 
	while preserving all other bits in n.
*/

using System;

class ModifyABit
{
	public static void Main ()
	{
		Console.Write ("Enter the number for formating: ");
		int number = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the position of the bit for formating: ");
		int p = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the bit value: ");
		int v = int.Parse (Console.ReadLine ());

		int mask = 1;
		mask <<= p;

		int temp = mask & number;
		temp >>= p;

		int result = 0;

		if (temp != v) {
			if (temp == 1) {
				if (v == 0) {
					result = mask ^ number;				
				}
			} else {
				if (v == 1) {
					result = mask | number;
				}
			}
		} else {
			result = number;
		}

		Console.WriteLine ("{0} ---> Your number", 
		                   					Convert.ToString(number, 2).PadLeft(16, '0'));

		Console.WriteLine ("{0} ---> Changed bit number", 
		                   					Convert.ToString(result, 2).PadLeft(16, '0'));

		Console.WriteLine ("The changed number is: {0}", result);
	}
}