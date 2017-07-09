
using System;

class Solution13_1
{
	public static void Solution()
	{

		Func<string, int> Len = str => str.Length;

		Console.WriteLine(Len("Welcome!"));

		Func<string, string> firstPart = str => str.Split(' ')[0];

		Console.WriteLine(firstPart("Sherlock Homles"));

		Log("Hello World", firstPart, Console.WriteLine);

	}

	static void Log(string message, Func<string, string> parse, Action<string> write)
	{
		write("Logging: " + parse(message));
	}
}