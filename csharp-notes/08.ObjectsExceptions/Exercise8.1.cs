/*


# PART 1

Q. Create the class heirachy:

 System.Exception
     MyOrganizationError
         MyAuthenticationError
             MyLoginError
             
         MyFormattingError
         
         
Q. Write a method Login which accepts two parameters a string username
 and an interger password (ie., a PIN).
 
 Within the function define two consts, CORRECT_PIN and CORRECT_USERNAME.
 
Q. If the username is CORRECT_USERNAME and the pin is CORRECT_PIN
 WriteLine "LOGGED IN"  otherwise throw a MyLoginError.
 
Q. Write a try/catch for this method, giving it the wrong details and
 WriteLine'ing "LOGIN FAILED" in the catch block.
 

# PART 2
Q. Create a method AuthUser which uses Console.ReadLine to get username
 and a password.
 
 Use the following code to convert the pin input into an integer...
 
 int userPin;
 
 bool parseSuccessful = int.TryParse(userInput, out userPin);

Q. If parseSuccessful is false or if the username is too short (eg. Length < 2)
 throw a MyFormattingError.
 
Q. Otherwise call Login().


# PART 3

Q. In Your Main Method:
    Now Call AuthUser() and handle the various kinds of error which may occur
*/
