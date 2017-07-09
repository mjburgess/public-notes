using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


// EXAMPLE 7 -- USING ALIAS
using User = System.Collections.Generic.Dictionary<string, string>;



//ALSO:  Collection initializer syntax  List<> { .... }  is via Enumerable.Add

namespace _11.LanguageCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 01 -- Concepts\n");


            Console.WriteLine("\nChapter 01.1 -- EXERCISE");


            Console.WriteLine("\nChapter 01.1 -- X");

            Console.ReadLine();
        }
    }


    // EXAMPLE 1 -- FOREACH
    class Example1
    {
        public static void Foreach()
        {

            //1. how does the foreach loop work?


            string message = "Hello";


            IEnumerator<char> er = message.GetEnumerator();

            // IEnumerable



            while (er.MoveNext())
            {
                Console.WriteLine(er.Current);
            }

        }
    }



    // EXAMPLE 2 -- ITERATORS
    class Example2
    {

        public class Countries : IEnumerable<string>
        {
            public string[] Names = {
                 "United Kingdom",
                 "Germany",
                 "Iran"
             };

            public IEnumerator<string> GetEnumerator()
            {
                foreach (string c in this.Names)
                {
                    yield return c;
                }
            }


            //REQUIRED FOR BACKWARDS COMPAT!
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }


        public static void Iterators()
        {
            var cts = new Countries();

            foreach (string country in cts)
            {
                Console.WriteLine(country);
            }
        }

        /* cf.

		// APROX..

		class AgesIterator {
		 int[] ages = {20, 30, 40};
		 
		 int position;
		 
		 public int NextAge() {
		     return ages[position++];
		 }
		}
        */
    }


    //EXAMPLE 3 -- ARRAYS
    class Example3
    {
        public static void Arrays()
        {

            //1. Clone

            StringBuilder[] builders = new StringBuilder[5];
            builders[0] = new StringBuilder("builder1");
            builders[1] = new StringBuilder("builder2");
            builders[2] = new StringBuilder("builder3");

            StringBuilder[] builders2 = builders;

            StringBuilder[] shallowClone = (StringBuilder[])builders.Clone();


            //2. Looping


            int[] myArray = { 1, 2, 3 };

            foreach (int val in myArray)
            {
                Console.WriteLine(val);
            }

            // Alternative:
            Array.ForEach(new[] { 1, 2, 3 }, Console.WriteLine);
        }
    }


    // EXAMPLE 4 -- LISTS
    class Example4
    {
        public static void Lists()
        {

            List<string> words = new List<string>();    // New string-typed list

            words.Add("melon");
            words.Add("avocado");
            words.AddRange(new[] { "banana", "plum" });
            words.Insert(0, "lemon");                           // Insert at start
            words.InsertRange(0, new[] { "peach", "nashi" });   // Insert at start

            words.Remove("melon");
            words.RemoveAt(3);                         // Remove the 4th element
            words.RemoveRange(0, 2);                   // Remove first 2 elements

        }
    }



    // EXAMPLE 5 -- DICTIONARIES
    class Example5
    {
        public static void Dictionaries()
        {
            var d = new Dictionary<string, int>();

            d.Add("One", 1);


            d["Two"] = 2;     // adds to dictionary because "two" not already present
            d["Two"] = 22;    // updates dictionary because "two" is now present
            d["Three"] = 3;



            foreach (KeyValuePair<string, int> kv in d)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }

            foreach (string s in d.Keys)
            {
                Console.Write(s);
            }

            foreach (int i in d.Values)
            {
                Console.Write(i);
            }
        }
    }


    // EXAMPLE 6 -- SETS
    class Example6
    {
        public static void Sets()
        {

            {
                var letters = new HashSet<char>("the quick brown fox");

                Console.WriteLine(letters.Contains('t'));      // true
                Console.WriteLine(letters.Contains('j'));      // false

                foreach (char c in letters)
                {
                    Console.Write(c);   // the quickbrownfx
                }
            }

            {
                var letters = new HashSet<char>("the quick brown fox");
                letters.IntersectWith("aeiou");
                foreach (char c in letters) Console.Write(c);     // euio
            }



            Console.WriteLine();
            {
                var letters = new HashSet<char>("the quick brown fox");
                letters.ExceptWith("aeiou");
                foreach (char c in letters) Console.Write(c);     // th qckbrwnfx
            }



            Console.WriteLine();
            {
                var letters = new HashSet<char>("the quick brown fox");
                letters.SymmetricExceptWith("the lazy brown fox");
                foreach (char c in letters) Console.Write(c);     // quicklazy
            }

        }
    }

  // EXAMPLE 7 -- USING ALIAS
    class Example7
    {
        public static void Aliasing()
        {
            User michael = new User();
            michael["username"] = "mjburgess";

            var users = new List<User>();

            users.Add(michael);
            users.Add(michael);


            foreach (User u in users)
            {
                Console.WriteLine(u["username"]);
            }
        }
    }


    // EXAMPLE 8 -- COLLECTIONS EXAMPLES
    class Example8
    {
        public static void CollectionExamples()
        {

            // DICTIONARIES
            Dictionary<string, string> user = new Dictionary<string, string>();

            user["Username"] = "Michael";
            user["Password"] = "TEST";


            var users = new Dictionary<int, Dictionary<string, string>>();

            users[0] = user;
            users[1] = user;

            foreach (var kv in users)
            {
                string username = kv.Value["Username"];

                Console.WriteLine($"{kv.Key} = {username}");
            }


            foreach (var aUser in users.Values)
            {
                Console.WriteLine(aUser["Username"]);
            }

            Console.WriteLine(users[0]["Username"]);



            /*


			//OR...
			var usersO = new Dictionary<int, Dictionary<string, string>>();
			Console.WriteLine((usersO[0] as Dictionary<string, string>)"Username"]);

			*/


            // LISTS + DICTS

            var row = new Dictionary<string, string>();

            row["location"] = "UK";
            row["height"] = "300 ft";


            var table = new List<Dictionary<string, string>>();


            table.Add(row);
            table.Add(row);
            table.Add(row);
            table.Add(row);

            foreach (var element in table)
            {
                Console.WriteLine(element["location"]);
            }


            Console.WriteLine(table[2]["height"]);




            // SETS
            string[] incoming = {
			 "Chris",
			 "Dom",
			 "Stef",
			 "Iain",
			 "Ross",
			 "Dave",
			 "Stef",
			 "Iain",
			 "Stef",
			 "Iain",
			};


            string[] badPeople = {
			 "Adam",
			 "Michael",
			 "Stef",
			 "Iain"
			};

            var namesSet = new HashSet<string>(incoming);
            var badSet = new HashSet<string>(badPeople);

            foreach (var element in namesSet)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            namesSet.ExceptWith(badSet);

            foreach (var element in namesSet)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine();
            namesSet = new HashSet<string>(incoming);

            badSet.SymmetricExceptWith(namesSet);

            foreach (var element in badSet)
            {
                Console.WriteLine(element);
            }
        }
    }

}
