
/*
					Problem 14.* Print the ASCII Table
	
		Find online more information about ASCII (American Standard Code for Information Interchange)
		and write a program that prints the entire ASCII table of characters
		on the console (characters from 0 to 255).
*/

using System;

class ASCIITable
{
	public static void Main ()
	{
		char symbol = (char) 1;

		for (int i = 1; i < 256; i++) 
		{
			Console.WriteLine (i + ": " + symbol);
			symbol += (char) 1;
		}
	}
}