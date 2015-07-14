
/*
 					 Problem 11. Bank Account Data

	A bank account has a holder name (first name, middle name and last name), 
	available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
	Declare the variables needed to keep the information for a single bank account
	using the appropriate data types and descriptive names.
*/

using System;

class BankAccountData
{
	public static void Main ()
	{
		string firstName = "Georgi";
		string lastName = "Georgiev";
		string surname = "Georgiev";
		double balance = 500.00;
		string bankName = "SB";
		string IBAN = "BG1212321";
		long firstCardNumber = 111111111111;
		long secondCardNumber = 22222222222;
		long thirdCardNumber = 33333333333;

		Console.WriteLine ("First name: " + firstName);
		Console.WriteLine ("Surname: " + surname);
		Console.WriteLine ("Last Name: " + lastName);
		Console.WriteLine ("Balance: " + balance);
		Console.WriteLine ("Bank: " + bankName);
		Console.WriteLine ("IBAN: " + IBAN);
		Console.WriteLine ("Card 1: " + firstCardNumber);
		Console.WriteLine ("Card 2: " + secondCardNumber);
		Console.WriteLine ("Card 3: " + thirdCardNumber);

	}
}