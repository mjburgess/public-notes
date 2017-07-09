using System.Collections.Generic;

/* 

Q. define class Person:
	it should have a generic ID
	a string Name
	and a method 'Tag' 
	which returns a string version of the ID tagged with the method's argument



When defined, the following code should succeed in Your Main Method:


		List<Person<string>> family = new List<Person<string>> {
			new Person<string> { ID = "Father", Name = "John" },
			new Person<string> { ID = "Mother", Name = "Anne" }
		};

		List<Person<int>> workers = new List<Person<int>> {
			new Person<int> { ID = 1, Name = "Bob"},
			new Person<int> { ID = 2, Name = "Alice" }
		};

		foreach (var p in family)
		{
			System.Console.WriteLine($"{p.Name} is {p.ID}, {p.Tag("-FAM")}");
		}

		foreach (var p in workers)
		{
			System.Console.WriteLine($"{p.Name} is {p.ID}, {p.Tag("-WRK")}");
		}
*/
	