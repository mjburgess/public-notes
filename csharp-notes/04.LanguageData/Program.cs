using System;
using System.Text;

namespace _04.LanguageTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 04 -- Data\n");
            Example1.Numerics();
            Example2.Text();
            Example3.Truth();
            Example4.Nothing();
            Example5.ImpliedTypes();
            Example6.Console();

            ///* //UNCOMMENT TO RUN SOLUTION
            Console.WriteLine("\nChapter 04 -- EXERCISE SOLUTION");
            Solution4_2.Solution();
            //*/


        }
    }



    //EXAMPLE1 -- NUMERIC DATA
    class Example1
    {
        public static void Numerics()
        {
            //1. numeric types
            int timeDifference = -100;
            long largeTimeDifference = -4000000000;

            int globalPopulation = unchecked((int)7000000000);

            byte red = 255, green = 0, blue = 0;

            Console.WriteLine($"The world's population is {globalPopulation}");
            Console.WriteLine($"RGB({red}, {green}, {blue})");


            // signed: sbyte (8), short (16), int (32), long (64)
            // unsigned: byte (8), ushort (16), uint (32), ulong (64)
            // reals: float (32), double (64), decimal (128)

            // s-range:  -2^(size - 1)  to 2^(size - 1) - 1
            // u-range: 0 to 2^(size) - 1


            // 2. representing literals
            int ten = 0xA;
            double ukPopulation = 6E07;
            double height = 1.81D; //D denotes double (not needed)

            //most useful suffixes

            float f = 4.5F;      //4.5 is a double! theref. F reqiuired
            decimal d = -1.23M;      //-1.23 equally, would not compile!


            // 3. conversions

            long i = 5;         // no suffix needed, long can represent 5 without loss

            /*

			For I x = y;
			 where I is some integer type..

			If T is larger than y, then conversion is implicit and allowed.

			otherwise...
			*/

            double realDistance = 1.8923;
            int aproxDistance = (int)realDistance;

            System.Console.WriteLine(
             $"The real distance is {realDistance} km which is about {aproxDistance} km"
            );



            //4. operators

            int population = 0;
            System.Console.WriteLine("population changes: ");
            System.Console.WriteLine(population++); //increment last
            System.Console.WriteLine(++population); //increment first
            System.Console.WriteLine(population);   // Q. value?


            System.Console.WriteLine(population--); //decrement last
            System.Console.WriteLine(--population); //decrement first
            System.Console.WriteLine(population);   // Q. value?


            int ratio = (population + 1) / 2;
            double realRatio = (population + 1) / 2;

            System.Console.WriteLine(
             $"population ratio is {ratio}, really {realRatio} ?"
            );

            realRatio = (population + 1.0) / 2.0;

            System.Console.WriteLine(
             $"population ratio is {ratio}, really {realRatio} ?"
            );


            // int popUKRatio = 60000000 / population; // -- *runtime* ERROR 



            // 5. overflow

            int min32bitInt = int.MinValue;
            int max32bitInt = int.MaxValue;


            System.Console.WriteLine(
             $"min int is {min32bitInt}, max int is {max32bitInt}"
            );


            min32bitInt--;
            max32bitInt++;


            System.Console.WriteLine(
             $"min int is {min32bitInt}, max int is {max32bitInt}"
            );

            /* 

			checked {
			 min32bitInt++;
			 max32bitInt--;
			} //*runtime* ERROR -- overflow

			checked {
			 int totalMoney = 7000000000 * 1000;
			}

			*/

            //6. imprecise

            double sliceOfCake = 1.0 / 6.0;

            double thirdCake = sliceOfCake + sliceOfCake;

            System.Console.WriteLine(sliceOfCake);
            System.Console.WriteLine(thirdCake);

            System.Console.WriteLine(
             sliceOfCake * 6.0 == thirdCake * 3.0
            );

            System.Console.WriteLine(sliceOfCake + sliceOfCake
                                 + sliceOfCake + sliceOfCake
                                 + sliceOfCake + sliceOfCake
                                 == 1.0);
        }
    }



    //EXAMPLE 2 -- TEXTUAL DATA
    class Example2
    {
        public static void Text()
        {
            //1. characters

            char chrA = 'A'; //2 byte unicode
            char euro = '\u20ac'; //�

            int ordEur = euro;
            ushort ordA = chrA;


            //2. string literals

            string location = "Leeds, United Kingdom";


            string city = "New York";
            string state = "New York";

            System.Console.WriteLine(city == state); //Q. ? value vs. reference semantics


            string message = "Hello\n,\tSherlock, how are you?";

            System.Console.WriteLine(message);


            string fileLocation = "C:\new\temp"; //Q. contents?

            System.Console.WriteLine(fileLocation);


            fileLocation = @"C:\new\temp"; //verbatim string literal
            System.Console.WriteLine(fileLocation);

            message = @"verbatim strings
can span multiple lines...
and include ""quotes"" ";


            System.Console.WriteLine(message);


            //3. operators

            location = city + ", " + state;  // concat

            System.Console.WriteLine($"Hello -- I'm at {location}"); //interp.


            System.Console.WriteLine($@"
Here's a literal interpolated verbatim string...

There are lots of formatting options for interpolation...

eg. What's hexidecimal of decimal 10? {10:X}
");



            //4. mutability

            string name = "Michael";
            System.Console.WriteLine(name[1]);

            // name[0] = 'm'; // --ERROR *compile time*, indexer is readonly


            string fullname = name + " Burgess"; //concat = new string


            //to get a mutable string use StringBuilder
            StringBuilder full = new StringBuilder("");

            full.Append("Mr. ");
            full.Append("Michael");
            full.Append(" Burgess");

            System.Console.WriteLine(full);


            //more on string handling later...
        }
    }


    // EXAMPLE 3 -- TRUTH
    class Example3
    {
        public static void Truth()
        {
            //1. equality 

            int distance = 5;
            int numApples = 5;
            int numPeople = 4;

            System.Console.WriteLine(distance == numApples);

            System.Console.WriteLine(distance != numApples);

            System.Console.WriteLine(distance != numPeople);


            // Q. value type equality vs reference equality 

            //2. logical operators

            bool isNear = distance < 10; //Q? T
            bool isBusy = numPeople > 10;    //Q? F
            bool isWellStocked = numApples / numPeople >= 1;  //Q? T, NB: int div.!

            System.Console.WriteLine(isNear);
            System.Console.WriteLine(isBusy);
            System.Console.WriteLine(isWellStocked);

            //a. binary
            System.Console.WriteLine(isNear && isBusy);
            System.Console.WriteLine(isNear && isBusy && isWellStocked);

            System.Console.WriteLine(isNear || isBusy);
            System.Console.WriteLine(isNear || isBusy && isWellStocked);

            System.Console.WriteLine(isNear && isBusy || isWellStocked);

            //b. ternary

            /*
			 T expression = CONDITION ? VALUE-TRUE : VALUE-FALSE;
			*/

            System.Console.WriteLine(isBusy ? "it's busy!" : "it's quiet..");


            //3. simple control flow

            if (isNear)
            {
                System.Console.WriteLine("It's near!");
            }
            else
            {
                System.Console.WriteLine("It's far!");
            }


            // || - subsequent conditions won't be checked if the first is True
            // && - as above, but if first is False
            // cf. short-circuiting

            string userInputPassword = null;

            if (userInputPassword != null && userInputPassword.Length > 5)
            {
                System.Console.WriteLine(userInputPassword);
            }
            else
            {
                System.Console.WriteLine("need a better pass!");
            }


        }
    }


    //EXAMPLE 4 -- NOTHING
    class Example4
    {
        public static void Nothing()
        {
            //Null & Null Operators
            //0. why null? -- "uninitialized"

            string emptyInput = "";
            int amountFilled = 0;

            //1. null-coalescing (~ value-or)

            string startName = null;
            string userInputName = null;
            string defaultName = "Guest";

            string name = startName ?? userInputName ?? defaultName;

            System.Console.WriteLine(name);

            //2. null-conditional (~maybe)
            System.Console.WriteLine(startName?.ToUpper() ?? name.ToUpper());


            //3. nullable types -- ie., nullable value types 

            int? charCount = userInputName?.Length;

            // charCount.GetType().Name;  Q. what's the type?

            //more on how these work later...
        }
    }



    //EXAMPLE5 -- IMPLICIT TYPES
    class Example5
    {
        public static void ImpliedTypes()
        {

            {
                var message = "Hello";
                var fullMessage = new System.Text.StringBuilder(message);
                var bmi = (float)(90 / 1.81 * 1.81);

                fullMessage.Append(", World!");


                System.Console.WriteLine($@"
     message is {message},
     full message is {fullMessage} and 
     bmi is {bmi}"
                );
            }

            //equivalent to..

            {
                string message = "Hello";
                System.Text.StringBuilder fullMessage = new System.Text.StringBuilder(message);
                float bmi = (float)(90 / 1.81 * 1.81);

                fullMessage.Append(", World!");


                System.Console.WriteLine($@"
     message is {message},
     full message is {fullMessage} and 
     bmi is {bmi}"
                );
            }

            //can be used in other assignment contexts..

            string[] enumerable = { "Some", "Ideas" };

            foreach (var element in enumerable)
            {
                System.Console.WriteLine(element);
            }



            var distance = 9; //statically (Compile Time) determined

            // distance += 9.5; //-- ERROR *compile time*


            System.Random r = new System.Random();
            var x = r.Next();            // Q. Type? 

            //Q. when should var be (not) used?


            // new / literals (ie. construction)
            // necessary only for annon. types

        }
    }

    //EXAMPLE 6 -- The Console
    class Example6
    {
        public static void Console() {
			string line = System.Console.ReadLine();

			int amount = int.Parse(line);

			System.Console.WriteLine(amount);
		}
    }
}
