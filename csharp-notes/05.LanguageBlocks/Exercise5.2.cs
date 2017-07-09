/*
* The aim here is to define three static methods: 
*  Login, GeneratePassword and GetUsername
* 
* And to use GeneratePassword() and GetUsername() with Login()
* 
* On your Program class:
* 
* Q. write a static Login method which takes two arguments,
*   a username and a password.
* 
*   if the password is 'test'
*       then print username, "ALLOWED"
*       otherwise print, username DENIED
* 
* 
* Q. define a method called GeneratePassword()
*   which randomly returns either "test" or "guest"
* 
* You will need to define a string array called passes.
* 
* HINT: int seed = (int)(System.Diagnostics.Stopwatch.GetTimestamp() % 1000);
        return passes[new System.Random(seed).Next(passes.Length)];
* 
* NB. Random(S).Next(L) takes an array length (L) and returns a valid index 
*       S is the seed value -- a fixed point to start generating random numbers from
* 
* 
* Q. define a method called GetUsername()
*   which accepts an integer ID which defaults to 0
*   The method should return the username at the ID position in the array:
*       new string[] { "guest", "staff", admin" }
* 
* 
* Q. add a documentation comment to this method which describes what it does
*
* In Your Main Method:
* 
* Q. call your Login method several times, 
*   supplying a username and a password from your other functions
*
* Q. call your Login method again, 
*       this time specify the password first then the username.
* 
* HINT: pass the arguments by name
*/