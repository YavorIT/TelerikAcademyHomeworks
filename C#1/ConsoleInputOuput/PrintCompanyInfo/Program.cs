
/*
 							Problem 2. Print Company Information

	A company has name, address, phone number, fax number, web site and manager.
	The manager has first name, last name, age and a phone number.
	Write a program that reads the information about a company and its manager
	and prints it back on the console.
*/

using System;

class PrintCompanyInfo
{
	public static void Main ()
	{
		Console.Write ("Enter the company name: ");
		string companyName = Console.ReadLine ();
		Console.Write ("Enter the company address: ");
		string companyAddress = Console.ReadLine ();
		Console.Write ("Enter the company phone number: ");
		string companyPhoneNumber = Console.ReadLine ();
		Console.Write ("Enter the company FAX: ");
		string companyFax = Console.ReadLine ();
		Console.Write ("Enter the company web site: ");
		string companyWebSite = Console.ReadLine ();
		Console.Write ("Enter the company manager: ");
		string companyManager = Console.ReadLine ();
		Console.Write ("Enter the manager's age: ");
		int managerAge = int.Parse (Console.ReadLine ());
		Console.Write ("Enter the manager's phone number: ");
		string managerPhoneNumber = Console.ReadLine ();

		Console.WriteLine (companyName);
		Console.WriteLine ("Address: {0}", companyAddress);
		Console.WriteLine ("Tel. {0}", companyPhoneNumber);
		Console.WriteLine ("FAX: {0}", companyFax.Length > 1 ? companyFax : "(no fax)");
		Console.WriteLine ("Web Site: {0}", companyWebSite);
		Console.WriteLine ("Manager: {0} (age: {1}, tel. {2})",
		                   companyManager, managerAge, managerPhoneNumber);
	}
}