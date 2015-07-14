
/*
									Problem 10. Employee Data

	A marketing company wants to keep record of its employees. 
	Each record would have the following characteristics:

	First name
	Last name
	Age (0...100)
	Gender (m or f)
	Personal ID number (e.g. 8306112507)
	Unique employee number (27560000…27569999)
	
	Declare the variables needed to keep the information for a single employee 
	using appropriate primitive data types. Use descriptive names. 
	Print the data at the console.
*/

using System;

class EmployeeData
{
	public static void Main ()
	{
		string name = "Ivan";
		string lastName = "Ivanov";
		int age = 20;
		char gender = 'm';

		ulong idNumber = 8306112507;
		uint uniqueNumber = 27560000;

		// I can make the last two numbers of type string if i won't use them for any arithmetical operations!

		Console.WriteLine ("Name: " + name);
		Console.WriteLine ("Last name: " + lastName);
		Console.WriteLine ("Age: " + age);
		Console.WriteLine ("Gender: " + gender);
		Console.WriteLine ("ID: " + idNumber);
		Console.WriteLine ("Unique number: " + uniqueNumber);

		string sIDNumber = "8306112507";
		string sUniqueNumber = "27560000";

		Console.WriteLine ("\n\n\n" + sIDNumber);
		Console.WriteLine (sUniqueNumber);
	}
}