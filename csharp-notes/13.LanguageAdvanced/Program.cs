using System;

namespace _13.LanguageAdvanced
{
    // ADVANCED FEATURES -- GROUP BY RELEVANCE TO LINQ

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 13 -- Language: Advanced\n");
            Example1.ExtensionMethods();
            Example2.Annon();
            Example3.Lambda();
            Example4.Closures();
            Example5.Lifetimes();


            Console.WriteLine("\nChapter 13 -- EXERCISE SOLUTION");
            Solution13_1.Solution();

            Console.ReadLine();
        }
    }


    // EXAMPLE 1 -- EXTENSION METHODS

    static class StringExtensions
    {
        public static int WordCount(this string theString)
        {
            return theString.Split(' ').Count();
        }
    }



    public static class StringHelper
    {
        public static bool IsCapitalized(this string s) => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]);

        public static string Pluralize(this string s) => s + "s";

        public static string Capitalize(this string s) => s.ToUpper();
    }



    class Example1
    {
        public static void ExtensionMethods()
        {

            Console.WriteLine("Perth".IsCapitalized());

            StringHelper.IsCapitalized("Perth");

            Console.WriteLine("sausage".Pluralize().Capitalize());
        }
    }




    // EXAMPLE 2 -- ANNOYMOUS TYPES
    class Example2
    {
        public static void Annon()
        {
            //1. type created by compiler
            var person = new
            {
                Name = "Michael",
                Age = 27
            };

            System.Console.WriteLine(person.ToString()); //overloaded
            System.Console.WriteLine(person.GetType().Name);

            var anotherPerson = new
            {
                Name = "Sherlock",
                Age = 27
            };

            //Q. same or different?
            System.Console.WriteLine(anotherPerson.ToString()); //overloaded
            System.Console.WriteLine(anotherPerson.GetType().Name);

            //*type* in this case is the same!

            //2. can use nameof() expression rather than K = V,
            // Q.  nameof(person.Name.Length) ?

            var personDetails = new
            {
                Summary = person.ToString(),
                person.Name.Length
            };

            System.Console.WriteLine(personDetails);

            //3. identity vs equality

            var xyLondon = new { X = 0, Y = 0 };  //dist. from capital, say
            var xyWashington = new { X = 0, Y = 0 };


            System.Console.WriteLine(xyLondon == xyWashington); //Q ?  F
            System.Console.WriteLine(xyLondon.Equals(xyWashington)); //  T

            //overriden Equals() method 
        }
    }



    // EXAMPLE 3 -- LAMBDA
    class Example3
    {
        delegate int Transformer(int x);

        public static void Lambda()
        {

            Transformer sq = x => x * x;

            Console.WriteLine(sq(5));        //25

            Transformer cube = x =>
            {
                return x * x * x;
            };


            Console.WriteLine(cube(3));

            Func<int, int> fifth = x => x * x * x * x * x;


            Action<string> doSomething = message => Console.WriteLine(message);

            Predicate<int> isAdult = age => age >= 18;

            doSomething(isAdult(20).ToString());
        }
    }


    // EXAMPLE 4 -- CLOSURES
    class Example4
    {
        public static void Closures()
        {
            string message = "Hello World!";

            Func<string, string> formatter = msg => msg.ToUpper();


            Console.WriteLine(formatter(message));


            Func<string, string> closure = msg => (msg + message).ToUpper();


            message = "Evening!";

            Console.WriteLine(closure("Morning! "));

            int population = 0;

            Func<int> birth = () => population++;

            birth();

            birth();

            birth();

            birth();


            Console.WriteLine(population);
        }
    }


    // EXAMPLE 5 -- CLOSURE LIFETIMES
    class Example5
    {
        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++;
        }

        public static void Lifetimes() {
            

			Func<int> fn = Natural();

			Console.WriteLine(fn());
			Console.WriteLine(fn());
		}
    }


}
