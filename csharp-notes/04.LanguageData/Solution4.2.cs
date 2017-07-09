
class Solution4_2
{
    public static void Solution()
    {
        string name, age, location, emptyName = null;

        System.Console.WriteLine("Name? ");
        name = System.Console.ReadLine();

        System.Console.WriteLine("Age? ");
        age = System.Console.ReadLine();

        System.Console.WriteLine("Location? ");
        location = System.Console.ReadLine();

        System.Console.WriteLine($@"
            Name:       {name}
            Age:        {age}
            Location:   {location}
        ");

        System.Console.WriteLine(emptyName ?? name);
       

        if (name.Length < 2 || age.Length < 2 || location.Length < 2)
        {
            System.Console.WriteLine("INPUT ERROR! (all should be > 2)");
        }

        int iAge = int.Parse(age);

        if (iAge < 18)
        {
            System.Console.WriteLine("ERROR: Age must be > 18");
        }

        System.Console.WriteLine(emptyName?.ToUpper() ?? name.ToUpper());
    }
}