using System;
using System.Text;

namespace _05.LanguageBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 05 -- Code Blocks\n");

            Example1.Arrays();
            Example2.Loops();
            Example3.Branches();
            Example4.Methods();
            Example5.Scopes();

            ///* //UNCOMMENT TO RUN SOLUTION
            Console.WriteLine("\nChapter 05 -- EXERCISE SOLUTION");
            Solution5_1.Solution();
            Solution5_2.Solution();
            //*/
            Console.ReadLine();
        }
    }


    //EXAMPLE 1 -- ARRAYS 
    class Example1
    {

        class Person { public string name; }

        public static void Arrays()
        {
            //1. declaration & initialization
            //a. value types
            int[] ages = new int[3]; //fixed size of 3

            ages[0] = 27;    //0 indexed
            ages[1] = 35;
            ages[2] = 17;    //access by position


            string[] names = {
                 "Sherlock",
                 "Mycroft",
                 "Informant"
                };


            int[] emptyArray = new int[100];

            System.Console.WriteLine(emptyArray[55]); //?
            System.Console.WriteLine(default(int)); //?

            //b. reference types


            Person[] people = new Person[100];

            //Q. what is default(Person) ?
            //EXTRA Q -- what is default(Person[]) ? 

            //1. iteration
            foreach (int age in ages)
            {
                System.Console.WriteLine(age);
            }


            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine($"{names[i]} is {ages[i]}");
            }


            //init. people

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
            }


            //2. multidimensional arrays (square vs. jagged)

            string[,] grid = new string[2, 2];

            for (int i = 0; i < grid.GetLength(0); i++) //GetLength == dim
                for (int j = 0; j < grid.GetLength(1); j++)
                    grid[i, j] = (i % 2) == 0 || (j % 2) == 0 ? "X" : "!";

            //NB. braces optional but always recommended!


            foreach (string element in grid)
            {
                System.Console.WriteLine(element);
            } //foreach iterates as flat

            string[,] sameGrid = {
                 {"X", "X"},
                 {"X", "!"}
                };


            int[][] jagged = new int[4][]; //four rows, but each abitarily-long

            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[] { 10 * i, 20 * i };
            }

            foreach (int[] row in jagged)
            {
                foreach (int element in row)
                {
                    System.Console.WriteLine(element);
                }
            }

            int[][] sameJagged = new int[][] {
				//Q. guesses?
				 new int[] {0, 0},
                 new int[] {10, 20},
                 new int[] {20, 40},
                 new int[] {30, 60}
                };


            // ERRORs

            // System.Console.WriteLine(names[names.Length]); //Q. ? *runtime* ERROR

            //length not part of type theref. runtime error (ish)
        }
    }



    //EXAMPLE 2 -- LOOPING
    class Example2
    {
        public static void Loops()
        {

            // 2. loops

            //a. while
            int numTries = 5;

            while (--numTries > 0)
            {
                System.Console.WriteLine($"{numTries} attempts left!");
            }

            System.Console.WriteLine("\nDo While...");


            numTries = 5;
            do
            {
                System.Console.WriteLine($"{numTries} attempts left!");
            } while (--numTries > 0);



            //b. for

            for (int i = 1, j = 1; j * i < 100; i++, j += 2)
            {
                System.Console.WriteLine(i * j);
            }


            //more typically..

            string[] names = { "Sherlock", "Watson", "Mycroft" };
            int[] ages = { 27, 30, 35 };

            for (int i = 0; i < ages.Length; i++)
            {
                System.Console.WriteLine($"{names[i]} is {ages[i]}");
            }

            //c. foreach 

            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }

            //more about how foreach works later...



            //d. jump statements (continue, break, return, goto)


            numTries = 5;
            while (--numTries > 0)
            {
                if (numTries == 2)
                {
                    continue;
                }

                System.Console.WriteLine(numTries);
            }



            numTries = 5;
            while (--numTries > 0)
            {
                if (numTries == 2)
                {
                    break;
                }

                System.Console.WriteLine(numTries);
            }



            numTries = 5;
            while (--numTries > 0)
            {
                if (numTries == 2)
                {
                    goto twoMessage;
                }

                System.Console.WriteLine(numTries);
            }

        twoMessage:
            System.Console.WriteLine("Two Happened!");

        }
    }



    //EXAMPLE 3 -- BRANCHING
    class Example3
    {
        public static void Branches()
        {
            //Control Flow 

            //1. conditional control flow
            //a. if/else if/else

            bool isAllowed = false;
            bool isSecure = true;

            string message = null;
            int accessState = 0;     //cf. Enums later

            if (isAllowed)
            {
                message = "Allowed in!";
                accessState = 1;

            }
            else if (isSecure)
            {
                message = "You're secure -- go in!";
                accessState = 2;

            }
            else
            {
                message = "NOT AUTHORIZED!";
                accessState = 3;
            }

            System.Console.WriteLine(message);


            //b. testing values with switch

            switch (accessState)
            {
                case 0:
                    message = "Access State Unknown";
                    break;
                case 1:
                case 2:
                    message = "Acess State Entered";
                    break;
                default:
                    message = "Access State DENIED!";
                    break;
            }

            System.Console.WriteLine(message);

        }
    }



    //EXAMPLE 4 -- METHODS
    class Example4
    {
        //1. Location of methods

        //unbound methods only for csi (C# Interactive Compiler, ie. the REPL)
        static string GetFullName(string title, string first, string second)
        {
            return String.Join(" ", new string[] { title, first, second });
        }


		// System.Console.WriteLine(GetFullName("Mr.", "Sherlock", "Holmes"));

		//in csc compiled programs, all methods are bound to an object 
		// or at static (ie., defined on a class)
		class Person
        {
            string title;
            string firstName;
            string lastName;

            public string GetFullName()
            {
                return String.Join(" ", new string[] { this.title, this.firstName, this.lastName });
            }
        }




        //2. 
        //a. stack vs heap

        // heap = block of memory for objects (reference types)
        // stack = block of memory for local variables *& params*

        static void stackOrHeap(string jobTitle) // STACK
        {  
            string name = "Dr. John Watson";     // HEAP
            int age = 35;                        // STACK
            bool isDr = true;                    // STACK

            System.Console.WriteLine(name);
        }

        static int factorial(int x)             // STACK
        {
            if (x == 0)
            {
                return 1;
            }

            return x * factorial(x - 1);
        }


        //b. "definite assignment" for local variables 
        static void defAssign()
        {
            int distance;       //*local variables* must be initialized

            //System.Console.WriteLine(distance); // --ERROR *compile-time*

            int[] distances = new int[3];

            System.Console.WriteLine(distances[1]); // Q. Error? No.
        }







        //3. arguments
        //a. passed by value (ie. copied)
        static void increasePeople(int total)
        {         //value type = copy value
            total++;

            System.Console.WriteLine(total);
        }

        static void testValArguments()
        {
            int numPeople = 0;
            increasePeople(numPeople);
            increasePeople(numPeople);
        }


        // pass by value with reference types
        static void appendID(StringBuilder id)
        {  //reference type = copy reference
            id.Append("101");           //Q. what does .Append do?
        }


        static void testRefArguments()
        {
            StringBuilder myId = new StringBuilder("");

            appendID(myId);
            appendID(myId);
            appendID(myId);

            System.Console.WriteLine(myId);

        }

        static void changeLocation(string location)
        {
            location = "New York";          //Q. what does = do? ~binds identifier to value

            System.Console.WriteLine(location);
        }

        static void testChangeRefArg()
        {
            string myLocation = "London"; //recall string is a ref type
            changeLocation(myLocation);
            System.Console.WriteLine(myLocation); // Q. ? 
        }



        //b. pass by ref
        static void increasePeopleByRef(ref int total)
        {    //ref when defined
            total++;

            System.Console.WriteLine(total);
        }

        static void testPassByRef()
        {
            int numPeople = 0;
            increasePeopleByRef(ref numPeople); //ref when called
            increasePeopleByRef(ref numPeople);
        }




        //-- out behaves like ref: accepts uninit'd vars 
        //but requires out vars to be assigned in method

        static bool operation(int left, int right, out int returnValue)
        {
            if (left < 0 || right < 0)
            {
                returnValue = 0;
                return false;
            }
            else
            {
                returnValue = left * right;
                return true;
            }
        }  //effectively get multiple return values

        static void testPassByOut()
        {
            int result;

            if (operation(10, 20, out result))
            {      //out when calling too!
                System.Console.WriteLine(result);
            }


            //.TryParse methods work this way...
            int maybeAge;
            if (int.TryParse("010", out maybeAge))
            {
                System.Console.WriteLine(maybeAge);
            }
        }



        //c. variadics + object type
        static void Print(params object[] strs)
        {
            foreach (object o in strs)
            {
                System.Console.WriteLine(o.ToString());
            }
        }

        static void testObjectType()
        {
            Print("Any", " Number of", "Args", 1, true, false);
        }




        //d. default/optional arguments
        static void Log(string[] messages, string prefix = "Logging: ")
        {
            foreach (string s in messages)
            {
                System.Console.WriteLine(prefix + s);
            }
        }

        static void testDefaultArgs()
        {
            Log(new string[] { "Error1", "Error2" });
        }





        //e. named parameters
        static void login(string username, string password, int pin)
        {
            if (password == "TEST" && pin == 1234)
            {
                System.Console.WriteLine($"{username} is logged in");
            }
        }

        static void testNamedArgs()
        {
            login(pin: 1234, password: "TEST", username: "User");
        }




        public static void Methods()
        {
            Console.WriteLine("testValArguments");
            testValArguments();

            Console.WriteLine("testRefArguments");
            testRefArguments();

            Console.WriteLine("testChangeRefArg");
            testChangeRefArg();

            Console.WriteLine("testPassByRef");
            testPassByRef();

            Console.WriteLine("testPassByOut");
            testPassByOut();

            Console.WriteLine("testObjectType");
            testObjectType();

            Console.WriteLine("testDefaultArgs");
            testDefaultArgs();

            Console.WriteLine("testNamedArgs");
            testNamedArgs();
        }
    }



    //EXAMPLE 5 -- SCOPE
    class Example5
    {
        //Q. how many independent variables are there?

        static int returnX(int x)
        {
            x = 20;
            return x;
        }

        static void testScope()
        {
            {
                int x = 10;
                System.Console.WriteLine(x);
                System.Console.WriteLine(returnX(x));
            }

            {
                int x = 15;
                System.Console.WriteLine(x);
            }

        }




        class SomeType
        {
            int x = 30;

            public int GetX()
            {
                return x;
            }

            public void DoNothing()
            {
                int x = 40;
                Console.WriteLine(x);
            }
        }

        static void testPrivateVar()
        {
            System.Console.WriteLine(new SomeType().GetX());
        }


        public static void Scopes()
        {
            Console.WriteLine("testScope");
            testScope();

            Console.WriteLine("testPrivateVar");
            testPrivateVar();
        }
    }


}
