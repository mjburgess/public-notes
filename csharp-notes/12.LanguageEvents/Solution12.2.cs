using System;
using System.Collections.Generic;

//PART 1
class Room
{
	public List<string> People;

	public event Responder OnRegistration;

	public Room()
	{
		this.People = new List<string>();
	}

	public void AddPerson(string name)
	{
		this.People.Add(name);
		this.OnRegistration();
	}
}

class Receptionist
{
	public void RespondToEntrance()
	{
		Console.WriteLine(nameof(Receptionist) + " Sighs");
	}
}

class Cleaner
{
	public void RespondToEntrance()
	{
		Console.WriteLine(nameof(Cleaner) + " Sighs");
	}
}



//PART 2
delegate void Responder();

class Solution12_2 {
    public static void Solution() {
		Room room205 = new Room();

		Cleaner c = new Cleaner();
		Receptionist r = new Receptionist();


		room205.OnRegistration += c.RespondToEntrance;
		room205.OnRegistration += r.RespondToEntrance;

		room205.AddPerson("Michael");
		room205.AddPerson("John");

        //room205.OnRegistration += () => Console.WriteLine("BANG!");
    }
}




