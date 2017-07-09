﻿using System;

class Solution1_2
{
	class Person { }
	class Detective : Person { }

	interface IDoctor { }
	class Medic : IDoctor { }

	public static void Solution()
	{
		Console.WriteLine("Exercise1.2");

		Person me = new Person();
		Detective marple = new Detective();
		Medic watson = new Medic();

		//Q. what is Person?
        Console.WriteLine("Person is a class (, type)");

		//Q. what is me?
		Console.WriteLine("me is an object ");

		//Q. what is the relationship between me and Person?
		Console.WriteLine("me is an instance of class Person");
        Console.WriteLine("me belongs to class Person");

		//Q. what is the relationship between Detective and Person?
		Console.WriteLine("Detective inherits from Person");
        Console.WriteLine("Detective is a child of Person");
        Console.WriteLine("Detective is a subclass of Person");
        Console.WriteLine("Every Detective is also a Person");
        Console.WriteLine("Detective is a Person");


		//Q. what's the realtionship betweeen Medic and IDoctor
		Console.WriteLine("Medic implements IDoctor");
        Console.WriteLine("Medic is an IDoctor");

		//Q. What does the is opertor do?
		//Q. What do the following print and why?

		Console.WriteLine(marple is Detective);
		Console.WriteLine(marple is Person);
		Console.WriteLine(watson is IDoctor);
	}


}