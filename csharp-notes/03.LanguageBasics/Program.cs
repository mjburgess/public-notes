using System;    //removes System prefix from identifer names
using System.Text;

namespace _03.LanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 03 -- Basics\n");

            @class.Identifiers();
            Example2.Comments();
            Example3.Constants();
            Example4.DataTypes();
            Example5.CustomTypes();
            Example6.Statics();
            Example7.Structs();
            Example8.Casting();
            Example9.OpPoly();

            ///* // UNCOMMENT TO RUN SOLUTION:

            Console.WriteLine("\nChapter 03 -- EXERCISE SOLUTION");
            Solution3_2.Solution();

            //*/
            Console.ReadLine();
        }
    }



    //EXAMPLE 1 -- IDENTIFERS
    // Q. what are the keywords?
    // Q. what are the identifers?
    class @class
    {
        //this class is named 'class' 
        // -- the @ prefix allows using keywords as identifers, but is not itself part of the name

        public static void Identifiers()
        {
            Console.WriteLine("A C# Program");
        }
    }


    /* some more keywords...

	abstract
	as
	base
	bool
	break
	byte
	case
	catch
	char
	checked
	class
	const
	continue
	decimal
	default...
	*/



    //EXAMPLE 2 -- COMMENTS
    // this is a single-line comment

    /*
    whereas
    this is a multi-line comment

    */

    /**
	this is a documentation comment which may contain XML doc tags
	*/
    class Example2
    {
        ///<summary>this is also a documentation comment</summary>
        public static void Comments()
        {

            Console.WriteLine("A C# Program!");
        }
    }


    // EXAMPLE 3 -- CONSTANTS
    class Example3
    {
        public static void Constants()
        {

            int variable = 10;

            variable++;



            // COMPILE-TIME CONSTANTS
            const int constant = 100;

            Console.WriteLine($"The value of my variable is {variable}");
            Console.WriteLine($"The value of my constant is {constant}");

        }
    }


    //EXAMPLE4 -- DATA TYPES
    class Example4
    {
        public static void DataTypes()
        {

            /*
			What does 'type' mean?
			 ~= denotes set of objects with a common property

			 what properties do ints have in common?
			 "on computers", esp., memory representation
			 the common properties are sometimes said to form a blueprint
			 theref. also, type ~= blueprint

			*/
            //pre-defined types

            System.String name = "Michael Burgess";
            System.Int32 age = 27;
            System.Boolean isAdult = age >= 18;


            string anotherName = "mjburgess";
            int anotherAge = 27;
            bool isAnotherAdult = anotherAge >= 18;


            // some operations on these


            string concatName = anotherName + " (" + name + ") is " + age.ToString();

            if (isAdult)
            {
                System.Console.WriteLine(concatName);
            }
            else
            {
                System.Console.WriteLine("Nope!");
            }

        }
    }




    //EXAMPLE 5 -- CUSTOM TYPES
    class Example5
    {
        class Person
        {

            // data each object of this type contains
            string name;
            int age;


            //constructor which builds particular objects of the type
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;             //Q. what is this?
            }

            //methods available to every object of this type

            public void PrintDetails()
            {
                System.Console.WriteLine($"{this.name} is {this.age} years old");
            }
        }

        public static void CustomTypes()
        {

            Person you = new Person("Sherlock Holmes", 27);
            Person me = new Person("Michael Burgess", 27);

            you.PrintDetails();
            me.PrintDetails();



            //cf. pre-defined types
            System.String emptyString = "";

            string anotherEmptyString = "";  //literals are constructors...
        }
    }


    //EXAMPLE6 -- STATICS
    class Example6
    {
        class Person
        {
            public string name;
            public static int population;

            public Person(string name)
            {
                this.name = name;
                Person.population++;
            }
        }

        public static void Statics()
        {
            Person me = new Person("Michael");
            Person you = new Person("Sherlock");

            System.Console.WriteLine(me.name);
            System.Console.WriteLine(you.name);

            System.Console.WriteLine(Person.population);


            //ERRORs:        
            //       System.Console.WriteLine(me.population);
            //       System.Console.WriteLine(you.population);}
        }
    }



    //EXAMPLE7 -- STRUCTS vs CLASSES
    class Example7
    {

        struct LocationValue
        {
            public string city, country;
        }

        class LocationReference
        {
            public string city, country;
        }

        public static void Structs()
        {

            LocationValue ldV = new LocationValue
            {
                city = "London",
                country = "UK"
            };

            LocationReference nyR = new LocationReference
            {
                city = "New York",
                country = "USA"
            };


            LocationValue london = ldV;
            LocationReference newyork = nyR;

            System.Console.WriteLine(ldV.city);
            System.Console.WriteLine(nyR.city);

            london.city = "LONDON";
            newyork.city = "NEW YORK";


            System.Console.WriteLine(ldV.city);   //unchanged
            System.Console.WriteLine(nyR.city);   //changed

            System.Console.WriteLine(london.city);
            System.Console.WriteLine(newyork.city);

            /*

            class types are reference types,
            variables denote *referenes* -- copying causes a copy of reference

            struct types are value types (eg. int, double..),
            variables denote *values* -- copying causes a copy of value

            other reference types: string, interfaces, delegates, arrays...
            other value types: all numeric, char, bool, enum

            (NB: the other two "types of type" are generics and pointers)
            */
        }
    }


    //EXAMPLE8 -- CASTING
    class Example8
    {
        public static void Casting()
        {
            int distance = 100;
            string units = "kilometers";


            // string interpolation
            System.Console.WriteLine($"the distance is {distance} {units}");


            // casting -- up & down

            float myHeight = 1.8F;
            double yourHeight = myHeight;


            double myWidth = 36.0;
            float yourWidth = (float)myWidth;

        }
    }


    //EXAMPLE9 -- OPERATOR POLYMORPHISM
    class Example9
    {
        public static void OpPoly()
        {
            // operator overloading

            string x = "1";
            string y = "2";
            string result = x + y;

            int X = 1;
            int Y = 2;
            int Result = X + Y;

            byte ascii1 = Encoding.ASCII.GetBytes("1")[0];
            byte ascii2 = Encoding.ASCII.GetBytes("2")[0];
            int result2 = ascii1 + ascii2;
        }
    }
}
