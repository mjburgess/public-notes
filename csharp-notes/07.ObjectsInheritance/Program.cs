 using System;

namespace _07.ObjectsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 06 -- Objects & Inheritance\n");

            Example1.Inheritance();
            Example2.Bases();
            Example3.Virtuals();
            Example4.Polymorphism();
            Example5.Protected();
            Example6.Hiding();
            Example7.Sealing();
            Example8.Boxing();
            Example9.OperatorOverloading();
            Example10.WhyPoly();

            Console.WriteLine("\nChapter 06 -- EXERCISE SOLUTION");

            Console.ReadLine();
        }
    }


    //EXAMPLE 1 -- Inheritance
    class Example1
    {

        class Person
        {
            public string Name;
            public int Age;
            
            public bool isAdult() => this.Age >= 18;
        }


        class Worker : Person
        {
            public string Job;

            public bool isEmployed() => this.Job != null;
        }


        class Officer : Worker
        {
            public Ranks Rank;

            public bool isSenior() => this.Rank >= Ranks.Inspector;
        }

        enum Ranks
        {
            Constable,
            Sergeant,
            Inspector,
            ChiefInspector
        }

        public static void Inheritance()
        {

            Person me = new Person
            {
                Name = "Michael",
                Age = 27
            };

            Worker miggins = new Worker
            {
                Name = "Mrs. Miggins",
                Age = 67
            };

            Officer plodd = new Officer
            {
                Name = "PC Plodd",
                Age = 40,
                Job = "Police Officer",
                Rank = Ranks.Inspector
            };

            System.Console.WriteLine($"{me.Name} is {me.Age}");

            System.Console.WriteLine($"{miggins.Name} is {miggins.Age} and is "
              + (miggins.isEmployed() ? "employed" : "not employed")
            );


            System.Console.WriteLine(
             $@"{plodd.Name} is {plodd.Age} and is "
                + (plodd.isEmployed() ? "employed" : "not employed")
             + $" as a {plodd.Job} ({plodd.Rank})"
            );

        }
    }



    //EXAMPLE 2 -- BASE CLASSES
    class Example2
    {
        enum Ranks
        {
            Constable,
            Sergeant,
            Inspector,
            ChiefInspector
        }

        class Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                this.Name = name.ToUpper();     //example functionality in parent
                this.Age = age;
            }

            public bool isAdult() => this.Age >= 18;
        }

        class Worker : Person
        {
            public string Job;

            public Worker(string name, int age, string job) : base(name, age)
            {
                Job = job;
            }

            public bool isEmployed() => this.Job != null;
        }

        class Officer : Worker
        {
            public Ranks Rank;

            public Officer(string name, int age, Ranks rank) : base(name, age, "Police Officer")
            {
                this.Rank = rank;
            }

            public bool isSenior() => this.Rank >= Ranks.Inspector;
        }


        public static void Bases()
        {
            Officer plodd = new Officer("Plodd", 40, Ranks.Inspector);


            System.Console.WriteLine(
             $@"{plodd.Name} is {plodd.Age} and is "
                + (plodd.isEmployed() ? "employed" : "not employed")
             + $" as a {plodd.Job} ({plodd.Rank})"
            );
        }
    }



    //EXAMPLE 3 -- VIRTUALS
    class Example3
    {
        class Product
        {
            public string Name;
            public virtual decimal Price { get; }
        }


        class Food : Product
        {
            public double Weight;
            public decimal PricePerKg;

            public override decimal Price
            {
                get { return this.PricePerKg * ((decimal)this.Weight / 1000.0M); }
            }
        }

        class Refill : Product
        {
            public int Size;
            public decimal PricePerUnit;

            public override decimal Price
            {
                get { return this.Size * this.PricePerUnit; }
            }
        }
        public static void Virtuals()
        {
            //TODO: COMPLETE VIRTUALS EG.
        }
    }



    //EXAMPLE 4 -- Polymorphism
    class Example4
    {

        //1. casting -- reference conversions


        class Animal
        {
            public virtual void Speak() => Console.WriteLine("SPEAK?");
        }

        class Bird : Animal
        {
            public override void Speak() => Console.WriteLine("tweet");
        }

        class Mammal : Animal
        {
            public override void Speak() => Console.WriteLine("SPEAK?");
        }

        class Dog : Mammal
        {
            public override void Speak() => Console.WriteLine("Woof!");
        }

        class Cat : Mammal
        {
            public override void Speak() => Console.WriteLine("Meow!");
        }



        class Vet
        {
            public void Heal(Animal a) => a.Speak();
            public void Heal(Mammal a) => a.Speak();
            public void Heal(Dog a) => a.Speak();
        }

        public static void Polymorphism()
        {


            Animal animal = new Animal();
            Bird bird = new Bird();

            Dog spot = new Dog();
            Cat fluffy = new Cat();

            animal = spot;

            animal.Speak();          //Woof!

            (animal as Dog).Speak(); //Woof!


            /*
			dog = animal;

			dog = animal as Dog;
			*/


            Vet v = new Vet();

            v.Heal(spot);
            v.Heal(bird);
            v.Heal(animal);
        }
    }



    //EXAMPLE 5 -- PROTECTED
    class Example5
    {

        class Person
        {
            public string Name { get; protected set; }

            public Person(string name)
            {
                Name = name;
            }
        }

        class Woman : Person {
            public Woman(string n) : base(n) { }

            public void Marry(string husband)
            {
                Name += "-" + husband.Split(' ')[1];
            }
        }

        public static void Protected() {
            Woman sarah = new Woman("Sarah White");
            sarah.Marry("Matthew Green");

        }
    }



    //EXAMPLE 6 -- HIDING
    class Example6
    {

        class Parent
        {
            public int ReturnAnInt()
            {
                return 0;
            }
        }

        class Child : Parent
        {
            public new int ReturnAnInt()
            {
                return 1;
            }
        }


        public static void Hiding()
        {
            Child c = new Child();
            Console.WriteLine(c.ReturnAnInt());

            Parent p = c;
            Console.WriteLine((p as Child).ReturnAnInt());
        }
    }



    //EXAMPLE 7 -- SEALING
    class Example7
    {

        class Renderer
        {
            public string Body;

            public virtual void Render() => Console.WriteLine(this.Body);
        }

        sealed class HtmlRenderer : Renderer
        {
            public override void Render() => Console.WriteLine($"<p>{this.Body}</p>");
        }

        public static void Sealing()
        {
            //TODO: Sealing Eg.
        }
    }


    //EXAMPLE 8 -- BOXING OBJECTS
    class Example8
    {

        //1. object

        public class Array
        {
            int cursor;
            object[] data;

            public Array(int size)
            {
                cursor = 0;
                data = new object[size];
            }

            public void Push(object obj)
            {
                data[cursor++] = obj;
            }

            public object Pop()
            {
                return data[--cursor];
            }
        }



        public static void Boxing()
        {

            // boxing = value -> reference

            int _value = 10;        // recall: value is a contextual keyword 
                                    // -- Q. what does it do?

            object reference = _value;

            //unboxing = reference -> value

            int anotherValue = (int)_value;

        }
    }


    //EXAMPLE 9 -- OPERATOR OVERLOADING
    class Example9
    {
        class Product
        {
            public string Code { get; set; }
            public decimal Price { get; set; }

            public override bool Equals(object obj)
            {
                Product other = obj as Product;
                return Code == other.Code && Price == other.Price;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(Product a, Product b)
            {
                // If both are null, or both are same instance, return true.
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                // If one is null, but not both, return false.
                if (((object)a == null) || ((object)b == null))
                {
                    return false;
                }

                // Return true if the fields match:
                return a.Equals(b);
            }

            public static bool operator !=(Product a, Product b)
            {
                return !(a == b);
            }
        }


        //NB. ToString
        public class Renderer
        {
            public string Body;

            public override string ToString()
            {
                return this.Body;
            }
        }

        public static void OperatorOverloading()
        {

            Product X = new Product() { Code = "AA3342", Price = 21.45M };
            Product Y = new Product() { Code = "AA3342", Price = 21.45M };
            bool Result = X == Y; // True}
        }


    }


    //EXAMPLE 10 -- WHY POLYMORPHSIM?
    class Example10
    {

        class Produce
        {
            private double price;
            public virtual double Price
            {
                get { return this.price; }
                set { this.price = value; }
            }
        }


        class Meat : Produce
        {
            public double Weight;
            public override double Price
            {
                get { return base.Price * this.Weight; }
            }
        }

        class Cartridge : Produce
        {
            public double Count;
            public override double Price
            {
                get { return base.Price * this.Count * 2; }
            }
        }

        static void HowMuch(Produce p)
        {
            Console.WriteLine(p.Price * 0.7);
        }

		static double BasketTotal(Produce[] basket)
		{
			double total = 0.0;

			foreach (var item in basket)
			{
				total += item.Price;
			}

			return total;
		}


		public static void WhyPoly()
        {

            HowMuch(new Produce { Price = 10 });
            HowMuch(new Meat { Price = 10, Weight = 2 });
            HowMuch(new Cartridge { Price = 10, Count = 5 });



            Produce[] basket = {
				 new Produce { Price = 10 },
				 new Meat { Price = 10, Weight = 2},
				 new Cartridge { Price = 10, Count = 5}
			};

            Console.WriteLine(BasketTotal(basket));
        }

    }
}
