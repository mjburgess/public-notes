﻿using System;
namespace _1.Concepts
{
    class Exercise1_2
    {
        class Person { }
        class Detective : Person { }

        interface IDoctor { }
        class Medic : IDoctor { }

        public static void Solution() //change to Main() your solution!
        {
            Console.WriteLine("Exercise1.2");

            Person me = new Person();
            Detective marple = new Detective();
            Medic watson = new Medic();

            //Q. what is Person?
            Console.WriteLine("Person is a(n) ");


            //Q. what is me?
            Console.WriteLine("me is a(n) ");

            //Q. what is the relationship between me and Person?
            Console.WriteLine("me is ... Person ");


            //Q. what is the relationship between Detective and Person?
            Console.WriteLine("Detective ... Person");


            //Q. what's the realtionship betweeen Medic and IDoctor
            Console.WriteLine("Medic ... IDoctor");

            //Q. What does the is opertor do?
            //Q. What do the following print and why?

            Console.WriteLine(marple is Detective);
            Console.WriteLine(marple is Person);
            Console.WriteLine(watson is IDoctor);
        }
    }
}