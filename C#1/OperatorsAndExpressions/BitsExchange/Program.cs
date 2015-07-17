
/*
				Problem 15.* Bits Exchange

	Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
	of given 32-bit unsigned integer.
*/

using System;

class BitsExchange
{
	public static void Main ()
	{
		Console.Write ("Enter a positive integer: ");
		uint number = uint.Parse (Console.ReadLine ());

		string bits = Convert.ToString (number, 2).PadLeft(32, '0');
		Console.WriteLine ("Your number: ");
		Console.WriteLine (bits);

		char bit3 = bits [32 - 4];
		char bit4 = bits [32 - 5];
		char bit5 = bits[32 - 6];

		char bit24 = bits [32 - 25];
		char bit25 = bits [32 - 26];
		char bit26 = bits[32 - 27];

		char[] result = new char[32];
		for (int i = 0; i < 32; i++) {
			result [i] = bits [i];
		}
		result [32 - 4] = bit24;
		result [32 - 5] = bit25;
		result [32 - 6] = bit26;

		result [32 - 25] = bit3;
		result [32 - 26] = bit4;
		result [32 - 27] = bit5;

		double finalResult = 0.0;
		for (int i = 31; i >= 0; i--) {
			if (result [i] == '1')
				finalResult += Math.Pow (2, (31 - i));
		}
		Console.WriteLine ("Converted number:");
		for (int i = 0; i < 32; i++) {
			Console.Write (result[i]);
		}
		Console.Write ("---> {0}", finalResult);
	}
}