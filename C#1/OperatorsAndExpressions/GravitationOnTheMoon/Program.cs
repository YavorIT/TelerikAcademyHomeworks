
/*
			Problem 2. Gravitation on the Moon

	The gravitational field of the Moon is approximately 17% of that on the Earth.
	Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;

class GravitationOnTheMoon
{
	public static void Main ()
	{
		Console.Write ("Enter your weight: ");
		double weightOnTheEarth = double.Parse (Console.ReadLine());
		Console.WriteLine ("On the moon you will be: {0}", (17.0 / 100.0) * weightOnTheEarth);
	}
}