using System;

// TODO: Memory Chapter 

namespace _15.LanguageMemory
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


    //EXAMPLE 1 -- GARBAGE COLLECTION & HEAP MANAGEMENT (REF TYPES)
    class Example1
    {
        public static void X() {
			//background threads garbage collect over heap (on CLR)
			//non-deterministic 

			//objects may require guaranteed clean up
			//eg. files require flushing


			//finalizers for guarantees
			//Dispose for determinism




		}
    }


	//EXAMPLE 2 -- FINALIZER
	/*
     * In general, C# does not require as much memory management as is needed 
     * when you develop with a language that does not target a runtime with garbage collection. 
     * This is because the .NET Framework garbage collector implicitly manages 
     * the allocation and release of memory for your objects. 
     * However, when your application encapsulates unmanaged resources such as windows, 
     * files, and network connections, you should use finalizers to free those resources. 
     * 
     * When the object is eligible for finalization, the garbage collector runs the Finalize method of the object.
     */

	class Example2
	{

		public class Destroyer
		{
			public override string ToString() => GetType().Name;

			//~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
		}



		//with inheritance
		class First
		{
			~First()
			{
				System.Diagnostics.Trace.WriteLine("First's destructor is called.");
			}
		}

		class Second : First
		{
			~Second()
			{
				System.Diagnostics.Trace.WriteLine("Second's destructor is called.");
			}
		}

		class Third : Second
		{
			~Third()
			{
				System.Diagnostics.Trace.WriteLine("Third's destructor is called.");
			}
		}

		class TestDestructors
		{
			static void Main()
			{
				Third t = new Third();
			}

		}
		/* Output (to VS Output Window):
			Third's destructor is called.
			Second's destructor is called.
			First's destructor is called.
		*/
		public static void X() { }
	}


    //EXAMPLE 3 -- PROBLEMS
	class Example3
	{
		public static void X() { }
	}


    //EXAMPLE 4 -- DISPOSING
	class Example4
	{
		public static void X() { }
	}


    //EXAMPLE 5 -- USING
	class Example5
	{
		public static void X() { }
	}


    //EXAMPLE 6 -- CONVENTIONS
	class Example6
	{
		public static void X() { }
	}
}
