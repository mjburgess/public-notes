//The code which produces an .exe can vary...

//Need not be called Program
public class Application
{

    //may return an int
    //may take a string[] (ie. array of strings)
    //must be called Main
    //must be static
    public static int Main(string[] args)
    {

        foreach (string arg in args)
        {
            System.Console.WriteLine(arg);
        }


        return 0; //0 - Success, Non-0 = Failure Code
                  // ...rarely used error mechanism in C#

    }

}