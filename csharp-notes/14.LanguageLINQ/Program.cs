using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _14.LanguageLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 14 -- Language: LINQ\n");
            Example1.Sugar();
            Example2.Forcing();
            Example3.Projection();
            Example4.Aggregates();
            Example5.LinqEg();

            Console.WriteLine("\nChapter 14 -- EXERCISE SOLUTION");
            Solution14_1.Solution();

            Console.ReadLine();
        }
    }


    // EXAMPLE 1 -- LINQ SUGAR
    class Example1
    {

        class Person
        {
            public string Name;
            public int Age;
        }


        public static void Sugar()
        {

            List<Person> people = new List<Person> {
				 new Person {
				     Name = "Michael",
				     Age = 27
				 },

				 new Person {
				     Name = "Sherlock",
				     Age = 30
				 },

				 new Person {
				     Name = "Watson",
				     Age = 35
				 }
				};


            var particular = from p in people
                             where p.Age > 29
                             select p;

            foreach (Person person in particular)
            {
                Console.WriteLine(person.Name);
            }


            var query = people.Where(p => p.Age > 29)
                           .Select(p => p);


            foreach (Person person in query)
            {
                Console.WriteLine(person.Name);
            }



            var actual = Enumerable.Select(
             Enumerable.Where(people,
                 delegate (Person p) { return p.Age > 29; }
             ),

             delegate (Person p) { return p; }
            );



            foreach (Person person in actual)
            {
                Console.WriteLine(person.Name);
            }

        }
    }


    // EXAMPLE 2 -- FORCING
    class Example2
    {
        public static void Forcing()
        {
            {

                string[] names = { "Tommy", "Fred", "Rashid", "Bobby" };

                var query = from n in names
                            where n.Length == 5
                            select n;

                foreach (string name in query)
                {
                    Console.WriteLine(name);
                }

                names[0] = "Mikes";

                foreach (string name in query)
                {
                    Console.WriteLine(name);
                }

            }

            {

                string[] names = { "Tommy", "Fred", "Rashid", "Bobby" };

                var query = (from n in names
                             where n.Length == 5
                             select n).ToList();

                foreach (string name in query)
                {
                    Console.WriteLine(name);
                }

                names[0] = "Mikes";

                foreach (string name in query)
                {
                    Console.WriteLine(name);
                }

            }
        }
    }


    // EXAMPLE 3 -- PROJECTION
    class Example3
    {
        class Person
        {
            public string Name;
            public int Age;
        }

        public static void Projection()
        {

            List<Person> people = new List<Person> {
             new Person {
                 Name = "Michael",
                 Age = 27
             },

             new Person {
                 Name = "Sherlock",
                 Age = 30
             },

             new Person {
                 Name = "Watson",
                 Age = 35
             }
            };


            var query = (from p in people
                        where p.Name.Length > 6
                        select p.Age).ToList();

            foreach (var el in query)
            {
                Console.WriteLine(el);
            }


            var query2 = from p in people
                         where p.Name.Length > 6
                         select new
                         {
                             NameLength = p.Name.Length,
                             Name = p.Name,
                             Age = p.Age
                         };


            foreach (var el in query2)
            {
                Console.WriteLine(el.Name);
            }



            string[] names = { "Sherlock", "Michael" };

            var matching = from n in names
                           join p in people
                           on n equals p.Name
                           select new { Name = n, Person = p };

            foreach (var person in matching)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("-----");

            var groupJoined = from n in names
                              join p in people
                              on n equals p.Name into matchingNames
                              select new { Name = n, Persons = matchingNames };

            foreach (var group in groupJoined)
            {
                Console.WriteLine(group.Name);


            }


        }
    }


    // EXAMPLE 4 -- AGGREGATION
    class Example4
    {

        class Customer
        {
            public string City;
            public decimal Balance;
        }


        public static void Aggregates()
        {

            List<Customer> customers = new List<Customer> {
			 new Customer { City = "London", Balance = 100},
			 new Customer { City = "London", Balance = 200},
			 new Customer { City = "London", Balance = 300},
			 new Customer { City = "New York", Balance = 400},
			};


            var baseQuery = from c in customers
                            where c.City == "London"
                            orderby c.Balance
                            select c;

            decimal avg = baseQuery.Average(c => c.Balance);
            decimal max = baseQuery.Max(c => c.Balance);
            decimal total = baseQuery.Sum(c => c.Balance);

            IEnumerable<decimal> qry2 = from c in customers
                                        where c.City == "London"
                                        select c.Balance;
            avg = qry2.Average();
            max = qry2.Max();
            total = qry2.Sum();

        }
    }


    // EXAMPLE 5 -- LINQ EXAMPLE
    class Example5
    {
        public static void LinqEg() {
            File.WriteAllLines("people.txt", new string[] {
                "michael, burgess",
                "sherlock, holmes",
                "john, watson"
            });

			//EXAMPLE
			var qry = from s in File.ReadAllLines("people.txt")
					  let fields = s.Split(',')
					  let first = fields[0]
					  let last = fields[1]
					  where first.Length > 4
					  select new { First = first, Last = last };

			qry.ToList().ForEach(p => Console.WriteLine("{0} {1}", p.First, p.Last));



            //TODO: Linq Set Ports
			/* TO DO...
			var query = new HashSet<int>(Range(0, 1024)).ExceptWith(new HashSet<int>(

					 from line in File.ReadAllLines('C:/System32/Drivers/etc/services')
					 let portPart = line.Split(' ')[10]
					 let port = portPart.Split('/')[1]
					 where line[0] != '#'
					 select port.ToInt()

				 ));


			*/
		}
    }
}
