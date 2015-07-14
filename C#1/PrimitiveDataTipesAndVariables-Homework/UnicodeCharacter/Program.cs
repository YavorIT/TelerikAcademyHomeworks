
/*
 				Problem 4. Unicode Character

		Declare a character variable and assign it with the symbol that has 
		Unicode code 42 (decimal) using the \u00XX syntax, and then print it. 
		The output should be *.
*/

using System;

class UnicodeCharacter
{
	public static void Main ()
	{
		char asterics = '\u002A';
		Console.WriteLine (asterics);
	}
}