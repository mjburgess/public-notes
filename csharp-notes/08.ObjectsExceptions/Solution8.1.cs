using System;

class MyOrganizationError : System.Exception { }

class MyAuthenticationError : MyOrganizationError { }

class MyFormattingError : MyOrganizationError { }


class Soluition8_1
{

	static void Login(string username, int pin)
	{
		const string CORRECT_USERNAME = "mjburgess";
		const int CORRECT_PIN = 1234;

		if (username == CORRECT_USERNAME && pin == CORRECT_PIN)
		{
			Console.WriteLine("LOGGED IN");
		}
		else
		{
			throw new MyAuthenticationError();
		}
	}


	static void AuthUser()
	{
		string userInputName, userInputPin;

		Console.WriteLine(" Username?");
		userInputName = Console.ReadLine();

		Console.WriteLine(" Pin?");
		userInputPin = Console.ReadLine();


		int userPin;

		bool parseSuccessful = int.TryParse(userInputPin, out userPin);

		if (parseSuccessful && userInputName.Length > 2)
		{
			Login(userInputName, userPin);
		}
		else
		{
			throw new MyFormattingError();
		}
	}


	public static void Main()
    {
        try
        {
            AuthUser();
        }
        catch (MyOrganizationError ex)
        {
            Console.WriteLine("DEAD!");
        }
    }
}