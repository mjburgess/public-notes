using System.Collections.Generic;

class Person<I> {
    public I ID;
    public string Name;

    public string Tag(string idTag) {
        return ID.ToString() + idTag;
    }
}

class Solution10_1 {

    public static void Solution() {
		List<Person<string>> family = new List<Person<string>> { 
            new Person<string> { ID = "Father",	Name = "John" }, 
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
    }
}