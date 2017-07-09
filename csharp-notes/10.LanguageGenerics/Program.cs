using System;
using System.Collections;
using System.Collections.Generic;

namespace _10.LanguageGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 10 -- Language: Generics\n");
            Example1.TheProblem();
            Example2.TheProblemAgain();
            Example3.TheSolution();
            Example4.GenericMethods();
            Example5.Statics();
            Example6.Constraints();
            Example7.Covarience();
            Example8.VarienceProblem();

            Console.WriteLine("\nChapter 01.1 -- EXERCISE");
            Solution10_1.Solution();

            Console.WriteLine("\nChapter 01.1 -- X");

            Console.ReadLine();
        }
    }


    // EXAMPLE 1 -- THE PROBLEM
    class Example1
    {
        public static void TheProblem()
        {
            ArrayList al = new ArrayList();
            al.Add("hello");
            al.Add("hello");
            al.Add("hello");
            al.Add(0);
            al.Add(100);
            al.Add(true);

            string firstElement = (string)al[0];
            int fifthElement = (int)al[4];

            Console.WriteLine(firstElement);
            Console.WriteLine(fifthElement * 10);

            foreach (object element in al)
            {
                Console.WriteLine(element * 10);
            }
        }
    }


    // EXAMPLE 2 -- THE PROBLEM II
    class Example2
    {
        public class ObjectStack
        {
            int position;

            public object[] Data = new object[10];


            public void Push(object obj) => Data[position++] = obj;


            public object Pop() => Data[--position];
        }


        public static void TheProblemAgain()
        {
            var stack = new ObjectStack();

            stack.Push("Hello World");
            stack.Push(100);

            Console.WriteLine(100 * (int)stack.Pop());
            Console.WriteLine(100 * (int)stack.Pop());
        }
    }

    // EXAMPLE 3 -- THE SOLUTION
    class Example3
    {

        public class Stack<T>
        {
            int position;

            T[] data = new T[100];



            public void Push(T obj) => data[position++] = obj;


            public T Pop() => data[--position];

        }


        public static void TheSolution()
        {
            Stack<int> ints = new Stack<int>();


            Stack<string> strings = new Stack<string>();

            ints.Push(100);
            strings.Push("Hello");
        }
    }


    //EXAMPLE 4 -- GENERIC METHODS
    class Example4
    {

        class NotGeneric
        {
            public void Zero<T>(T[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = default(T);
                }
            }
        }

        public static void GenericMethods()
        {

            var ng = new NotGeneric();

            int[] ages = { 30, 40, 50 };
            string[] names = { "Michael", "Dom", "Stef" };

            ng.Zero<int>(ages);
            ng.Zero<string>(names);

            /*
             
            ng.Zero(ages);
            ng.Zero(names);

             */
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }



    //EXAMPLE 5 -- GENERICS & STATICS
    class Example5
    {

        class Human { }
        class Dog { }


        //*generic* class
        class Animal<T>
        {
            public static int Count;
        }


        public static void Statics()
        {
            Console.WriteLine(++Animal<Human>.Count);
            Console.WriteLine(++Animal<Human>.Count);
            Console.WriteLine(++Animal<Human>.Count);

            Console.WriteLine(++Animal<Dog>.Count);
            Console.WriteLine(++Animal<Dog>.Count);
            Console.WriteLine(++Animal<int>.Count);
            Console.WriteLine(++Animal<string>.Count);
        }
    }


    // EXAMPLE 6 -- GENERIC CONSTRAINTS
    class Example6
    {
        class Person : IComparable<Person>
        {
            public int NetWorth;

            int IComparable<Person>.CompareTo(Person b)
            {
                return this.NetWorth.CompareTo(b.NetWorth);
            }
        }


        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        //generates  -->
        static int MaxIntSpecific(int a, int b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void Constraints()
        {
            Console.WriteLine(Max<int>(10, 20));

            var p = new Person { NetWorth = 10 };
            var x = new Person { NetWorth = 20 };

            Console.WriteLine(Max<Person>(p, x).NetWorth);
        }
    }


    // EXAMPLE 7 -- COVARIENCE
    class Example7
    {

        class Animal { }
        class Bear : Animal { }
        class Camel : Animal { }

        public static void Covarience()
        {
            Animal[] As = new Animal[10];
            Bear[] Bs = new Bear[10];

            As = Bs;
        }
    }


    // EXAMPLE 8 -- VARIENCE, THE PROBLEM
    class Example8
    {

        public class Stack<T>
        {
            int position;
            T[] data = new T[100];
            public void Push(T obj) => data[position++] = obj;
            public T Pop() => data[--position];
        }


        class Animal { }
        class Bear : Animal { }
        class Camel : Animal { }

        public static void VarienceProblem()
        {
            Stack<Bear> bears = new Stack<Bear>();
            //Stack<Animal> animals = bears;           //ERROR
        }


        // EXAMPLE 9 -- VARIENCE, THE SOLUTION

        class Example9
        {
			interface IStackPop<out T> { T Pop(); }
            interface IStackPush<T> { void Push(T o); }

			class Animal { }
			class Bear : Animal { }
			class Camel : Animal { }

			public class Stack<T> : IStackPush<T>, IStackPop<T>
			{
				int position;
				T[] data = new T[100];
				public void Push(T obj) => data[position++] = obj;
				public T Pop() => data[--position];
			}

            public static void VarienceSolution() {

				Stack<Bear> bears = new Stack<Bear>();
				bears.Push(new Bear());

				// Stack<Animal> animals = bears;  //-- WOULD ALLOW...
				//animals.Push(new Camel()); 
				// -- ie. Bears -> Animals -> Mixed! -- we want to preserve bears

				// put the bears in a "bears going out" context
				// ie., "disable" Push
				//therefore allow IPoppable<Animal>  rather than Stack<Animal> 

				IStackPop<Animal> animals = bears;
				Animal a = animals.Pop();
			}
        }
    }

}