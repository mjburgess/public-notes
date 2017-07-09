// csc can compile code into libraries which get used by executables
// libraries are not themselves programs


namespace MyLibrary
{

    public class SomethingUseful
    {
        public void AnInterestingMethod()
        {

            System.Console.WriteLine("Some Helper Method!");

        }
    }

}


// we'll cover namespaces later


// csc /target:library chapter3c.cs




