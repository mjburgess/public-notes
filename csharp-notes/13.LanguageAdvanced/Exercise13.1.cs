/*
In the Main Method of your Program:

	Q. use Len to WriteLine the length of the string "Welcome!"

	    Func<string, int> Len = str => str.Length;

	Q. Write a lambda function called firstPart 
        which when given a full name, returns the first name
		HINT: the type will be Func<string, string>
		HINT: .Split(' ')


	Q. use firstPart to Console.WriteLine the first name of "Sherlock Holmes"



    Q. define a static void method called Log which accepts:
        a string message, 
        a Func<string, string> parse 
        an Action<string> write 

        the method should parse the message 
        and write "Logging: " + the message


    Q. In your main method, Log "Hello World" 
        where parse is firstPart 
        and write is Console.WriteLine

*/

