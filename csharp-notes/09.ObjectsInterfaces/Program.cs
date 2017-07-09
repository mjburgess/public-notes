 using System;

namespace _09.ObjectsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 09 -- Objects & Interfaces\n");

            Example1.Abstracts();
            Example2.Interfaces();
            Example3.Multiple();
            Example4.Virtuals();

            Console.WriteLine("\nChapter 09 -- EXERCISE SOLUTION");

            Solution9_1.Solution();

            Console.ReadLine();
        }
    }



    // EXAMPLE 1 -- ABSTRACTS
    class Example1
    {


        abstract class Animal
        {
            abstract public string GetDNA(); //cf. virtual = may; abstract = must

            public int GetRFID()
            {
                return this.GetDNA().Length;
            }
        }


        class Dog : Animal
        {
            public override string GetDNA()
            {
                return "ABGTUC";
            }
        }
        public static void Abstracts()
        {
            var d = new Dog();

            d.GetRFID();
        }
    }

    // EXAMPLE 2 -- INTERFACES
    class Example2
    {

        public interface IShape
        {
            double Area();
            double NumEdges();
        }



        public class Circle : IShape
        {
            public double Radius;

            public double Area()
            {
                return this.Radius * this.Radius * System.Math.PI;
            }

            public double NumEdges()
            {
                return 1;
            }
        }


        public class Rectange : IShape
        {
            public double Length, Width;

            public double Area()
            {
                return this.Length * this.Width;
            }

            public double NumEdges()
            {
                return 4;
            }
        }


        public class Square : Rectange
        {
            public int doThat() => 5;
        }




        public static void Interfaces()
        {
            var circ = new Circle
            {
                Radius = 10
            };


            IShape shape = new Square
            {
                Length = 5,
                Width = 5
            };

            Console.WriteLine(circ.Area());

            Console.WriteLine(shape.Area());

            Console.WriteLine(shape.GetType() == typeof(Square));

            (shape as Square)?.doThat();
        }
    }


    //EXAMPLE 3 -- MULTIPLE IMPLEMENTATION
    class Example3
    {


        interface IWalker
        {
            bool Move();
        }

        interface ISwimmer
        {
            bool Move();
        }


        class Dolphin : IWalker, ISwimmer
        {
            bool IWalker.Move()
            {
                return false;
            }

            bool ISwimmer.Move()
            {
                return true;
            }

            public bool Move()
            {
                ISwimmer self = this;
                return self.Move();
            }

            //public bool Move() => (this as ISwimmer).Move();
            
        }

        public static void Multiple()
        {
            var dolphin = new Dolphin();

            IWalker walk = new Dolphin();
            ISwimmer swim = new Dolphin();

            Console.WriteLine(walk.Move());
            Console.WriteLine(swim.Move());

            Console.WriteLine(dolphin.Move());

        }
    }

    // EXAMPLE 4 -- VIRTUAL IMPLEMENTATION
    class Example4
    {


        public interface IPrinter { void Print(); }

        public class TextPrinter : IPrinter
        {
            void IPrinter.Print() => Print();

            protected virtual void Print() => Console.WriteLine("<p>EXAMPLE</p>");
        }


        public class HtmlPrinter : TextPrinter
        {
            protected override void Print() => Console.WriteLine("EXAMPLE");
        }

        public static void Virtuals() { 
            //TODO: Finish Virtual + Interface Eg.
        }
    }
}
