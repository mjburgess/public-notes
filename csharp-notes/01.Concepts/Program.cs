/*
* CHAPTER:      01 -- Concepts 
* EXERCISE:     
* EXPERIENCE:   Imperative, Procedural Languages? Object Orientation?    
* APPLICATIONS: To understand the design & construction of programs. 
*/
#pragma warning disable CS0184
#pragma warning disable CS1718

using System;

/*
 * These demonstrations follow the convention:
 *  the namespace describes the chapter number and name
 *  the code grouped under Main() runs all the examples 
 *  each example contains code grouped under a name describing the example. 
 * 
 */

namespace _1.Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 01 -- Concepts\n");

			Console.WriteLine("\nChapter 01.1 -- Imperative Programming");
			Example1.ImperativeProgramming();

            Console.WriteLine("\nChapter 01.2 -- Procedural Programming");
            Example2.ProceduralProgramming();

            Console.WriteLine("\nChapter 01.3 -- OO Programming");
            Example3.ObjectOrientedProgramming();

            Console.WriteLine("\nChapter 01.4 -- Objects");
            Example4.Objects();

            Console.WriteLine("\nChapter 01.5 -- Relationships");
            Example5.Relationships();

            /* // UNCOMMENT TO RUN SOLUTIONS:
             
            Console.WriteLine("\nChapter 01.1 -- EXERCISE SOLUTIONS");
            Solution1_1.Solution();
            Solution1_2.Solution();
            
            */
            Console.ReadLine();
        }
    }



    //EXAMPLE1 -- IMPERATIVE PROGRAMMING
    class Example1
    {
        public static void ImperativeProgramming()
        {
            // Introduction to Programming (with Objects...) 

            //1. The foundations of imperative programming

            // state
            var x = 1;
            var y = 1;

            x++;     //state change

            //behaviour (NB: commands, ie. grammatical imperatives)
            System.Console.WriteLine(x);


            //identity

            System.Console.WriteLine(x == x);
            System.Console.WriteLine(x == y);

            //types

            int heightCm = 181;
            double heightM = 1.81;

            System.Console.WriteLine($"your height is {heightCm} cm or {heightM} m");


            // heightCm += 1.5;      -- NOT POSSIBLE

            heightCm += (int)1.5;

            System.Console.WriteLine($"your height is now {heightCm} cm ");

        }
    }



	//EXAMPLE2 -- PROCEDURAL PROGRAMMING
	class Example2
    {
        //functions are generic, applying to all people (ie. name/height/weights)
        static double GetPersonBMI(double theirHeight, double theirWeight)
        {
            return theirWeight / (theirHeight * theirHeight);
        }

        static string GetPersonDescription(string theirName, double theirHeight, double theirWeight)
        {
            double theirBMI = GetPersonBMI(theirHeight, theirWeight);

            return $"{theirName} is {theirHeight} m and {theirWeight} kg (BMI={theirBMI:f1})";
        }


        public static void ProceduralProgramming()
        {
            //2. procedural programming (particular type of imperative) groups data and behaviour separately

            //data is specific to a particular person
            string myName = "Sherlock Holmes";
            double myHeight = 1.81;
            double myWeight = 70.0;


           
            System.Console.WriteLine(GetPersonDescription(myName, myHeight, myWeight));
        }

    }



	//EXAMPLE3 -- OO PROGRAMMING
	class Example3
    {
        //3. object oriented programs group data and behaviour

        // the *particular* data with generic functions
        // so that particular data "knows how to" behave itself, 
        // rather than having operations "done to" it

        //What are the properties (english-meaning) of a person?
        class Person
        {
            public string name;
            public double height;
            public double weight;

            double GetBMI()
            {
                return this.weight / (this.height * this.height);
            }

            public string GetDescription()
            {
                double bmi = this.GetBMI();

                return $"{this.name} is {this.height} m and {this.weight} kg (BMI={bmi:f1})";
            }
        }

        public static void ObjectOrientedProgramming()
        {
            Person mycroft = new Person
            {
                name = "Mycroft Holmes",
                height = 1.9,
                weight = 70
            };

            Person watson = new Person
            {
                name = "Dr. Watson",
                height = 1.81,
                weight = 75
            };

            System.Console.WriteLine(watson.GetDescription());
            // we'll leave this syntax here for now, and continue with it later on
        }
    }


	//EXAMPLE4 -- OBJECTS
	class Example4
    {
        //INTERLUDE: CODE FOR THE EXAMPLES BELOW, IGNORE FOR NOW...
        class Detective
        {
            public string name;
            public double height;
            public double weight;

            public void Eat(double amount)   
            {
                this.weight += amount;
            }
        }
        // END INTERLUDE...


        public static void Objects()
        {

            //4. The foundations of imperative programming (OO)

            /*
			 We need to go back to state, behaviour, identity and type
			 and clarify what each now mean as applied to *objects*
				 (...which are not merely simple values).

			*/

            //sherlock is the object, Detective its type
            Detective sherlock = new Detective
            {     //NB. we can set the state of the object when we create it
                name = "Sherlock Holmes",
                height = 1.81,
                weight = 70
            };

            //what is its state?

            System.Console.WriteLine(sherlock.name);
            System.Console.WriteLine(sherlock.height);
            System.Console.WriteLine(sherlock.weight);

            //how does it's state change?

            sherlock.Eat(0.5); //sherlock increases its own weight


            //what is its behaviour?
            // its methods, eg. sherlock.Eat


            //identity?
            var me = sherlock;
            var you = sherlock;


            System.Console.WriteLine(me == you);


            System.Console.WriteLine(sherlock == new Detective
            {
                name = "Sherlock Holmes"
            });

            // sherlock == someone else called sherlock ? NOPE



            /*
			 for simple data values identity and equality are the same
			 for objects these come apart

			 conditions underwhich we might want to say two objects are "equal" 
			 (eg. equal in price) do not imply the objects are the same

			 your house might be "equal-to" a £300,000 check 
			 but I cannot demolish your house and replace it with a piece of paper

			 identity means (according to Leibniz at least) equal in every possible way

			 For x to identitical to y is for x to be y
			 For Michael to be identiical to Mike is for Michael and Mike to refer to exactly the same object. 
			*/

        }
    }





    //EXAMPLE5 -- RELATIONSHIPS
    class Example5
    {
        //5. Objects, Types and their relationship

        //a. the type of an object is the group it belongs to 
        //ie., its class in the english sense
        //but there are multiple types in C#: class types, interface types, delegate types, etc.

        class Person
        {

        }


        //b. an object can belong to many groups
        //eg. a particular detective is a Person and also a Son, a Human, etc.

        //all detectives are people
        class Detective : Person
        {

        }

        //all doctors are people
        class Doctor : Person
        {

        }


        public static void Relationships()
        {

            Person me = new Person();
            Person you = new Person();

            /*
			 me and you belong to the class Person
			 the type 'Person' denotes the set {me, you}
			 'new Person' adds an element (a person) to the set
			 
			 cf. bool means {true, false}, int means {-2^32, ..., 0, ..., 2^32 - 1}
			*/


            Detective sherlock = new Detective();
            Doctor watson = new Doctor();

            System.Console.WriteLine(sherlock is Person);
            System.Console.WriteLine(sherlock is Detective);

            System.Console.WriteLine(watson is Person);
            System.Console.WriteLine(watson is Doctor);
 // 'is' expression's given expression is never of the provided type
            System.Console.WriteLine(watson is Detective);
             // 'is' expression's given expression is never of the provided type


            //c. objects however have one 'cannonical' type, the type they were made from
            //ie., the type new'd -- even though they belong to multiple

            System.Console.WriteLine(sherlock.GetType().Name);
            System.Console.WriteLine(watson.GetType().Name);


            //d. there are two ways of saying an object belongs to multiple types

            //1. if the supertype is an interface = implementation
            //2. if the sypertype is a class = inheritance

            //NB. supertype is the larger group, ie. the type on the RHS of : 
            // SubType : SuperType



            //let's stop here on the syntax/demos and talk about the concepts... 
            //syntax revisited / continued 

        }


        public static void Questions()
        {

            //   class Person { }

            Person me = new Person();
            Person you = new Person();

            //Q. how many people are there?
            //... ie. how many values (object) of the type Person are there?
            //A. 2

            //   class Detective : Person {}

            Detective holmes = new Detective();
            Detective marple = new Detective();

            //Q. how may people are there?
            //A. 4

            System.Console.WriteLine(holmes is Detective);
            System.Console.WriteLine(me is Detective);
            System.Console.WriteLine(holmes is Person);

            System.Console.WriteLine(holmes.GetType().Name);
        }
    }
}

/* OUTPUT:


Chapter 01 -- Concepts


Chapter 01.1 -- Imperative Programming
2
True
False
your height is 181 cm or 1.81 m
your height is now 182 cm 

Chapter 01.2 -- Procedural Programming
Sherlock Holmes is 1.81 m and 70 kg (BMI=21.4)

Chapter 01.3 -- OO Programming
Dr. Watson is 1.81 m and 75 kg (BMI=22.9)

Chapter 01.4 -- Objects
Sherlock Holmes
1.81
70
True
False

Chapter 01.5 -- Relationships
True
True
True
True
False
Detective
Doctor


 */
