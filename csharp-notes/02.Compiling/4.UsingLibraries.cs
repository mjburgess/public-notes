// you can then create programs which use your libraries

public class Program
{

    public static void Main()
    {        
        var su = new MyLibrary.SomethingUseful();

        su.AnInterestingMethod();
    }

}


/*
You must *reference* the .dll when compiling however, or else...

Microsoft (R) Visual C# Compiler version 1.3.1.60616
Copyright (C) Microsoft Corporation. All rights reserved.

chapter3d.cs(7,16): error CS0246: The type or namespace name 'MyLibrary' could not be found (are you missing a using directive or an assembly reference?)
*/


// csc CSC4-using-dlls.csx /reference:CSC3-libraries.dll