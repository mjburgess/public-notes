#include <iostream>

using namespace std;

// the compiler needs some basic information to know how to call a function:
// it needs to know the function's return type, name and parameter types
// it does *not* need the actual implementation of the function to compile the program 

//(... the implementation could be provided by an external library, eg. .dll, which is linked-to 
// your program *as it runs* ...) 

// it is often convenient to provide the prototype of the function (return & param types) before using the function
// and the actual implementation of the function, in source, later on 
// this enables functions to:
// call one-another before anywhere in source -- rather only after they have been defined
// and users of a library of functions to rely merely on the prototypes and not need the source-defintion


//eg. a prototype:
string get_username(string);        // params may be named:     string get_username(string prefix);   -- often clearer

int main(void) {
    string un = get_username("Mr. ");         //call the function *before* it has been implemented

    cout << "the username is " << un << endl;    
}

//implement the function later on...
string get_username(string prefix) {
    return prefix + "Michael Burgess";
}


// prototypes are usually stored in separate header files (.hpp)
// and the implementations of functions in separte c++ files (.cpp)
// the header files are #include'd so the compiler has enough information

// custom header files are included using double-quotes, #include "myheader.hpp"
// header files from the standard library (or special directories the compiler knows about) use angle brackets
// eg., #include <iostream>

// the implementation files are either: 
// 1. passed when compiling (ie., as an arugment to the compiler) so everything is linked at compile-time (ie. statically linked)
// or, 2. later-on by the operating system as .dlls (dynamically linked)


/* OUTPUT (notes/16.function-prototypes.cpp):
the username is Mr. Michael Burgess

*/