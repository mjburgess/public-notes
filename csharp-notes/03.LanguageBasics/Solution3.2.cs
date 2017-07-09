
class Detective
{
    public string Name;
    public int Age, Rank;

    public static int Population;
 
    public Detective()
    {
        Detective.Population++;
    }

    /*
        COMMENT
    */
    public void Describe()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Age: {Age}");
        System.Console.WriteLine($"Rank: {Rank}");
        System.Console.WriteLine($"Retired: {IsRetired()}");
        System.Console.WriteLine($"Senior: {IsSenior()}");
	}

    //COMMENT
    public bool IsSenior()
    {
        return Rank > 3;
    }

    public bool IsRetired() {
        return Age >= 65;
    }
}


struct Officer
{
    public string Name;
    public int Age, Rank;

	public void Describe()
	{
		System.Console.WriteLine($"Name: {Name}");
		System.Console.WriteLine($"Age: {Age}");
		System.Console.WriteLine($"Rank: {Rank}");
		System.Console.WriteLine($"Retired: {IsRetired()}");
		System.Console.WriteLine($"Senior: {IsSenior()}");
	}

	public bool IsSenior()
	{
		return Rank > 3;
	}

	public bool IsRetired()
	{
		return Age >= 65;
	}
}

class Solution3_2
{
    public static void Solution()
    {
        Detective me = new Detective { Name = "Bob", Age = 35, Rank = 3};
        Detective you = new Detective { Name = "Alice", Age = 70, Rank = 1 }; 

        me.Describe();
        you.Describe();


		//EXTRA
		Officer one = new Officer { Name = "Bob", Age = 35, Rank = 3 };


        Detective anotherMe = me;
        anotherMe.Name = "Bobbie";
        me.Describe();


        Officer two = one;
        two.Name = "Bobbie";
        one.Describe();

    }
}