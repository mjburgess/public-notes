using System;

namespace _06.ObjectsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 06 -- Objects & Classes\n");
            Example1.Review();
            Example2.Methods();
            Example3.This();
            Example4.Initialization();
            Example5.Properties();
            Example6.Statics();
            Example7.Partials();
            Example8.Enums();
            

            Console.WriteLine("\nChapter 06 -- EXERCISE SOLUTION");
            Solution6_1.Solution();
            Console.ReadLine();
        }
    }


    //EXAMPLE 1 -- REVIEW
    class Example1
    {
        //review + readonly 


        //1.class type
        class Person
        {
            //2. fields

            //private
            string name = "some person";


            //public
            public int Age = 30;        //conventionally capital

            public readonly int NumEyes = 2;


            //3. methods
            public void GetDescription()
            {
                System.Console.WriteLine($@"
			         name is {this.name}
			         age is {this.Age}
			         number of eyes is {this.NumEyes}
			     ");

            } //this = the particular new'd object

        }

        public static void Review()
        {


            //4. creating objects

            Person p = new Person();

            p.Age--; //not error..

            //p.name.ToUpper(); //-- ERROR *ct*
            p.GetDescription(); //only access what is public



            /*
			readyonly vs const

			const int a
			must be initialized @ compile time theref. only value-types (Q. why?)

			readonly int a
			uses default value & can be initialized @ run time
			*/


        }
    }


    // EXAMPLE 2 -- METHODS
    class Example2
    {
        //1. methods

        class Person
        {
            string name = "ExamplePerson";
            public int Age = 30;

            public void GetDescription()
            {
                System.Console.WriteLine($@"
			         name is {this.name}
			         age is {this.Age}
			         adult? {this.isAdult()}
			     ");
            }

            //a. expression-bodied methods  
            public bool isAdult() => this.Age >= 18;

            //b. method overloading

            public string GetName(string prefix)
            {
                return prefix + this.name;
            }

            public string GetName(bool withPrefix = true)
            {
                return "Name is " + this.name;
            }

            //overload on name + param list
            //NOT: return type
            //NOT: params / int[]
            //NOT: ref / out
        }

        //2. constructors
        class Item
        {
            public string Name;
            public decimal Price;       //decimal for currency 
            public bool IsNew;

            public Item(string name, decimal rrp)
            {
                this.Name = name;
                this.Price = rrp;
            }

            //overloaded
            public Item(string name, decimal rrp, bool isNew) : this(name, rrp)
            {
                this.IsNew = isNew;

                if (!isNew)
                {
                    this.Price *= 0.75M; //M required!
                }
            }
        }


        static void testConstruct()
        {
            Item[] basket = {
             new Item("Eggs", 2.50M),        //M required!
			 new Item("Sony A7RII", 2000, false)
            };

            foreach (Item item in basket)
            {
                System.Console.WriteLine($"{item.Name} is {item.Price}");
            }
        }

        //b. can be private


        class Utility
        {
            int scale;

            private Utility(int scale)
            {
                this.scale = scale;
            }


            public static int SomethingUseful()
            {
                var self = new Utility(100);

                return self.scale * 35;
            }
        }

        static void testPrivateConstruct()
        {
            System.Console.WriteLine(Utility.SomethingUseful());

            /*

			NB.

			for classes, the C# compiler automatically generates 
			a parameterless public constructor
			if and only if you do not define any constructors. 

			*/
        }

        public static void Methods()
        {
            testConstruct();
            testPrivateConstruct();
        }
    }



    // EXAMPLE 3 -- THIS
    class Example3
    {

        class Person
        {
            string name;

            public Person(string name)
            {
                this.name = name;
            }

            public Person()
            {
                name = "Guest"; //"this."  not required! 
            }

            public string GetName()
            {
                return name.ToUpper();
            }

            public Person SetName(string name)
            {
                this.name = name;       // using this to avoid ambiguity
                return this;            //NB. returning
            }

            public void RegisterAccount(Account a)
            {
                a.Owner = this;
            }
        }


        class Account
        {
            public Person Owner;
        }


        public static void This()
        {
            var me = new Person("Michael");

            System.Console.WriteLine(me.SetName("Michael Burgess").GetName());


            var acc = new Account();
            me.RegisterAccount(acc);

            System.Console.WriteLine(acc.Owner.GetName());
        }
    }



    //EXAMPLE 4 -- INITIALIZATION
    class Example4
    {

        class Person
        {
            public string Name;
            public int Age;
            public string FavColour;

            public Person(string name)
            {
                this.Name = name.ToLower();
            }

            public Person() { }
        }


        static void testInit()
        {
            //call constructor & initialize
            var me = new Person("Michael Burgess")
            {
                Age = 27,
                FavColour = "Purple"
            };

            //requires a param'less constructor
            var you = new Person
            {
                Name = "Sherlock Holmes",
                Age = 27,
                FavColour = "Purple"
            };


            System.Console.WriteLine(me.Name);
            System.Console.WriteLine(you.Name);

        }
        //optional params in constructors...

        class Account
        {
            public string Name;
            public int Balance;

            public Account(string name, int starting = 0)
            {
                Name = name;
                Balance = starting;         //recall this. optional
            }

            public Account() { }
        }


        static void testNamed()
        {
            var myAccount = new Account("Michael");
            var yourAccount = new Account("Sherlock", starting: 100); //named optional parameter


            //compare with

            var herAccount = new Account
            {
                Name = "Irene",
                Balance = 1000
            };


            //NB. optional parameters compiled-into class
            // Q. use optional or initializer? 
            //zero starting balance seems stable enough
        }

        public static void Initialization()
        {
            testInit();
            testNamed();
        }
    }



    //EXAMPLE 5 -- PROPERTIES
    class Example5
    {


        //1. getters and setters backed by a private field

        class Account
        {
            decimal balance;

            public decimal Balance
            {
                get { return this.balance; }
                set { this.balance = value > 0 ? value : 0; }
            }
        }


        static void testGetSet()
        {

            var myAccount = new Account
            {
                Balance = -100                  //setter contains logic
                                                //behaves like variable
            };

            System.Console.WriteLine(myAccount.Balance);

            myAccount.Balance = 100;

            System.Console.WriteLine(myAccount.Balance);
        }

        //2. composites


        class Person
        {
            public string firstName, lastName;

            public string FullName
            {
                get
                {
                    return this.firstName + " " + this.lastName;
                }

                set
                {
                    string[] nameParts = value.Split();
                    this.firstName = nameParts[0];
                    this.lastName = nameParts[1];
                }
            }
        }

        static void testComposite()
        {
            System.Console.WriteLine(new Person()
            {
                firstName = "Mr. Michael",
                lastName = "Burgess"

            }.FullName);


            System.Console.WriteLine(new Person()
            {
                FullName = "Mr. Michael Burgess"
            }.firstName);


        }


        //3. expression-bodied

        class Person2
        {
            public string firstName, lastName;

            public string FullName => this.firstName + " " + this.lastName;
        }


        static void testExpressionBody()
        {
            System.Console.WriteLine(new Person2()
            {
                firstName = "Dr. John",
                lastName = "Watson"
            }.FullName);


        }

        //4. automatic properties


        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; private set; } //public read-only

            public Item(decimal price)
            {
                this.Price = price;
            }
        }

        static void testAutoProperty()
        {
            var lens = new Item(599.99M)   //Q. M ?
            {
                Name = "Zeiss 35mm FE"
            };

            // lens.Price = 600; // -- ERROR *ctime*

            System.Console.WriteLine($"{lens.Name} costs {lens.Price}");
        }



        //b. with initilizer

        class Lens
        {
            public string Name { get; } = "Zeiss 35mm FE";
            public decimal Price { get; set; } = 600M;
        }


        //c. readonly

        class Room {
            public int Walls => 4;
        }


        static void testInit()
        {

            var myLens = new Lens
            {
                Price = 550
            };


            System.Console.WriteLine($"{myLens.Name} costs {myLens.Price}");
        }

        public static void Properties()
        {
            testGetSet();
            testComposite();
            testExpressionBody();
            testAutoProperty();
            testInit();
        }
    }


    class Example6
    {
        //1. static fields


        class UnitedKingdom
        {
            public static readonly string Capitol = "London";
            public static int Population = 65000000;

            public const string ISO = "en-gb";
            //not a "real field" -- nb. cannot be referenced in other assemblies!
        }


        static void testStaticField()
        {


            var uk = new UnitedKingdom();

            //uk.Capitol //--ERROR


            System.Console.WriteLine(UnitedKingdom.Capitol);
            System.Console.WriteLine(UnitedKingdom.Population);

            UnitedKingdom.Population = 60000000;

            System.Console.WriteLine(UnitedKingdom.Population);

            //NB. mutable static fields are essentially global variables
        }

        //2. static methods
        class Country
        {

            //NB. factory
            public static UnitedKingdom GetUK()
            {
                return new UnitedKingdom();
            }

            public static string[] GetISO()
            {
                return new string[] { "en-gb", "en-us" }; //etc.
            }
        }


        static void testStaticMethod()
        {
            var UK = Country.GetUK();

            System.Console.WriteLine(Country.GetISO()[1]);
        }


        //3. static constructors (!)


        class France
        {
            public static readonly double Population;

            static France()
            {                   //once per type
                Population = 66.03;             //Q. readonly?

                System.Console.WriteLine($"Population is {Population}");
            }
        }

        static void testStaticConstruct()
        {

            var fr = new France();
            var fr2 = new France();

            // France.Population += 1.0; //-- ERROR readonly

            System.Console.WriteLine(France.Population);

        }



        //4.  static field considerations

        class Germany
        {
            public static double Population = 80.62;

            public static double Immigration = 2;

            public static double NetChange = Immigration - Emmigration;

            public static double Emmigration = 1.24;

        }

        static void testStaticInitOrder()
        {

            System.Console.WriteLine(Germany.NetChange);
        }

        public static void Statics()
        {
            testStaticField();
            testStaticMethod();
            testStaticConstruct();
            testStaticInitOrder();
        }
    }


    class Example7
    {

        partial class Form
        {
            private string name;

            public Form()
            {
                this.name = nameof(Form);
            }
        }

        partial class Form
        {
            public string GetName()
            {
                return this.name;
            }
        }


        public static void Partials()
        {

            Form f = new Form();

            Console.WriteLine(f.GetName());
        }
    }

    class Example8
    {

        enum Ranks
        {
            Constable,
            Sergeant,
            Inspector,
            ChiefInspector
        }



        enum Move : byte
        {
            Up,
            Down,
            Left,
            Right
        }


        static void testEnum()
        {
            Ranks particularRank = Ranks.Constable;
            Move direction = Move.Up;


            switch (direction)
            {
                case Move.Up:
                    Console.WriteLine(direction);
                    break;

                default:
                    Console.WriteLine("Not " + direction.ToString());
                    break;
            }

            int directionInt = (int)Move.Up;

            string[] longNames = {
 "Moving Up", "Moving Down"
};

            Console.WriteLine(longNames[(int)Move.Up]);

        }


        //2. flag enums

        [Flags] // means enum = collection of flags (multiply settable)
        enum MoveFlag : byte
        {
            Up,
            Down,
            Left,
            Right
        }


        static void testFlag()
        {
            MoveFlag myMove = MoveFlag.Up & MoveFlag.Left;

            if ((myMove & MoveFlag.Up) != 0)
            {
                Console.WriteLine("Contains Up!");
            }
        }

        public static void Enums()
        {
            testEnum();
            testFlag();
        }
    }
}
