using System;

namespace _12.LanguageEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 12 -- Language: Events\n");
            Example1.Delegates();
            Example2.Generics();
            Example3.Multicasting();
            Example4.Events();
            Example5.Conventions();


            Console.WriteLine("\nChapter 12 -- EXERCISE SOLUTION");
            Solution12_2.Solution();

            Console.ReadLine();
        }
    }


    // EXAMPLE 1 -- DELEGATES
    class Example1
    {

        delegate int Transformer(int x);

        static int Square(int x) => x * x;
        static int Cube(int x) => x * x * x;



        public static void Delegates()
        {
            int randInt = 4;

            Transformer fn;

            if (randInt > 5)
            {
                fn = Square;
            }
            else
            {
                fn = Cube;
            }

            Console.WriteLine(fn(5));

            Console.WriteLine(fn.Invoke(5));
        }
    }

    // EXAMPLE 2 -- GENERICS + DELEGATES
    class Example2
    {

        static int Square(int x) => x * x;

        delegate int Transformer(int x);

        static void Transform(int[] ints, Transformer fn)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = fn(ints[i]);
            }
        }



        delegate T Mapper<T>(T x);

        static void Map<E>(E[] array, Mapper<E> fn)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fn(array[i]);
            }
        }

        public static void Generics()
        {

            int[] ages = { 10, 20, 30 };

            Transform(ages, Square);


            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }


            //generic...

            Map<int>(ages, Square);


            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }


            //ages.ForEach(Console.WriteLine);
        }
    }




    // EXAMPLE 3 -- DELEGATES FOR MULTICASTING
    class Example3
    {
        delegate void Log();  /* class Log<void, void> {} */

        static void Error()
        {
            Console.WriteLine(nameof(Error));
        }

        static void Warning()
        {
            Console.WriteLine(nameof(Warning));
        }

        public static void Multicasting()
        {
            Log fns = Error;

            fns += Warning;

            fns();
        }
    }



    // EXAMPLE 4 -- EVENTS
    class Example4
    {

        delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);

        class Stock
        {
            string name;
            decimal price;


            public Stock(string name)
            {
                this.name = name;
            }

            public event PriceChangeHandler PriceChangeEvent;

            public decimal Price
            {
                get { return this.price; }
                set
                {
                    if (this.price == value)
                    {
                        return;
                    }
                    else
                    {
                        decimal oldPrice = price;
                        this.price = value;

                        this.PriceChangeEvent(oldPrice, this.price);
                    }
                }
            }
        }

        static void handle(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine($"{oldPrice} -> {newPrice}");
        }

        public static void Events()
        {

            var stock = new Stock("GOOG");

            stock.PriceChangeEvent += handle;

            stock.Price = 100;

            stock.Price = 200;
        }
    }


    // EXAMPLE 5 -- STANDARD FORM CONVENTIONS FOR EVENTS
    class Example5
    {
		class Stock
		{
			string name;
			decimal price;


			public Stock(string name)
			{
				this.name = name;
			}

			public event EventHandler PriceChangeEvent;

			protected virtual void OnPriceChanged(EventArgs e)
			{
				PriceChangeEvent?.Invoke(this, e);
			}

			public decimal Price
			{
				get { return this.price; }
				set
				{
					if (this.price == value)
					{
						return;
					}
					else
					{
						this.price = value;
						OnPriceChanged(EventArgs.Empty);
					}
				}
			}

		}

		static void handle(decimal oldPrice, decimal newPrice)
		{
			Console.WriteLine($"{oldPrice} -> {newPrice}");
		}


		static void handleEA(object sender, EventArgs e)
		{
			Stock s = (Stock)sender;

			Console.WriteLine($"{s.Price}");
		}


        public static void Conventions() {
			var stock = new Stock("GOOG");

			stock.PriceChangeEvent += handleEA;

			stock.Price = 100;

			stock.Price = 200;
		}
    }
}
