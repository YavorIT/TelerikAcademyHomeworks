
/*
						Problem 8. Isosceles Triangle

	Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
								   ©

								  © ©

								 ©   ©

								© © © ©
*/

using System;

class IsoscelesTriangle
{
	public static void Main ()
	{
		char copyrightSymbol = '\u00A9';

		Console.WriteLine ("\t   " + copyrightSymbol + "\n");
		Console.WriteLine ("\t  " + copyrightSymbol + " " + copyrightSymbol + "\n");
		Console.WriteLine ("\t " + copyrightSymbol + " " + " " + " " + copyrightSymbol + "\n");
		Console.WriteLine ("\t" + copyrightSymbol + " " + copyrightSymbol + " " + 
		                   							copyrightSymbol + " " + copyrightSymbol + "\n");


	}
}

