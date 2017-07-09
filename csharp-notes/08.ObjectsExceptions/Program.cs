using System;
using System.Net;

namespace _08.ObjectsExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 08 -- Concepts\n");

            Example1.TheProblem();
            Example2.TheSolution();
            Example3.Multiple();
            Example4.Throwing();
            Example5.Custom();
            Example6.Finally();
            Example7.Principles();

            Console.WriteLine("\nChapter 08 -- EXERCISE SOLUTION");

            Soluition8_1.Main();

            Console.ReadLine();
        }
    }


    //EXAMPLE 1 -- THE PROBLEM
    class Example1
    {

        static int Div10(int x)
        {
            return 10 / x;
        }

        public static void TheProblem()
        {
            int y = Div10(0);

            Console.WriteLine(y);
        }
    }


    //EXAMPLE 2 -- THE SOLUTION
    class Example2
    {

        static int Div10(int x) => 10 / x;

        public static void TheSolution()
        {

            try
            {
                int result = Div10(0);
                Console.WriteLine(result);
            }

            catch (DivideByZeroException ex)
            {
                
                Console.WriteLine("E: " + ex.Message);
            }


            //2. several kinds of error
            string popStr = "7000000000";

            try
            {
                int population = int.Parse(popStr);
                Console.WriteLine(population);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Malformed!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Must be less than ");
                Console.Write(int.MaxValue);
            }
        }
    }

    //EXAMPLE 3 -- CATCHING MULTIPLE
    class Example3
    {

        public static void Multiple()
        {

            string webpage = null;

            try
            {
                //TODO: fix webclinet
                webpage = new WebClient().DownloadString("http://thisDoesNotExist");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                Console.WriteLine("Took too long!");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
            {
                Console.WriteLine("DNS Lookup Failed!");
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Some other failure: {ex.Status}");
            }


            System.IO.StreamReader reader = null;
            try
            {
                reader = System.IO.File.OpenText(@"C:\Windows\System32\Drivers\etc\hosts");
                Console.WriteLine(reader.ReadToEnd());
            }
            finally
            {
                reader?.Dispose();
            }
        }
    }


    //EXAMPLE 4 -- THROWING
    class Example4
    {
        static void Display(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Console.WriteLine(name);
        }

        public static void Throwing()
        {

            string input = null;

            try
            {
                Display(input);
            }

            catch (ArgumentNullException ex)
            {
                //ignore?
            }


            using (WebClient wc = new WebClient())
            {     //calls .Dispose()
                try
                {
                    input = wc.DownloadString("http://google.com/");
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                    {
                        Console.WriteLine("DNS Lookup Failed!");
                    } //we can handle this kind of exception

                    else
                    {
                        throw;    //re-throws exception since we couldnt handle it
                    }
                }
            }
        }
    }


    // EXAMPLE 5 -- CUSTOM EXCEPTIONS
    class Example5
    {
        class MyException : System.Exception
        {

        }

        public static void Custom()
        {

            throw new MyException();
        }
    }

    //EXAMPLE 6 -- FINALLY
    class Example6
    {
        public static void Finally()
        {

            System.IO.StreamReader reader = null;
            try
            {
                reader = System.IO.File.OpenText(@"C:\Windows\System32\Drivers\etc\hosts");
                Console.WriteLine(reader.ReadToEnd());
            }
            finally
            {
                reader?.Dispose();
            }

            //TODO: complete catch clause
            /* try
            {
                using (reader = System.IO.File.OpenText(@"C:\Windows\System32\Drivers\etc\hosts"))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }*/
        }
    }


    //EXAMPLE 7 -- PRINCIPLES
    class Example7 {
		class MyOrganizationError : System.Exception { }

		class MyAuthenticationError : MyOrganizationError { }

		class MyFormattingError : MyOrganizationError { }


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


        public static void Principles() {
			AuthUser();
        }
    }
}
