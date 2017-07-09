using System;

class Solution1_1
{
	public static void Solution()
	{
		Console.WriteLine("Exercise1");

		string name = "Michael";
		double age = 26 + 2.0 / 12;
		string favColour = "purple";


		System.Console.WriteLine(name + "'s Profile");
        System.Console.WriteLine(name + " likes " + favColour);
		age++;

		if (age > 27.0)
		{
			System.Console.WriteLine("Happy Birthday!");
		}
	}

}
            
