#include <iostream>

using namespace std;

// FUNCTIONS


// a function is a named sequence of operations which may depend on zero or more variables
// for example, the recipie for making cake can be described as a function from (flour, eggs, sugar, butter) to sponge
// that is, given an amount of each variable you can follow a series of steps, in sequence, to produce a sponge 

double bake(double flour, int eggs, double sugar, double butter) {
    return flour + (eggs * 50) + sugar + butter;       
}

/*  we then 'call' bake (ie. run the sequence of operation it defines) 
    given *particular* values for its variables called parameters:

//  bake(100, 2, 100, 100);

pure functions are those which merely combine their arguments in order calculate a new value, as above. 
impure functions however have additional effects, such as writing output to a file or the screen. 

pure functions can be thought of as exactly substitutable for their return expression, above... 

// bake(100, 2, 100, 100)  becomes  100 + (2 * 50) + 100 + 100  -- without any loss of meaning

impure functions, since they do more than just return values, cannot be substituted this way, 

//eg., cout << "message";    cannot be substitued for any value without changing the operation of the program
*/


// DEFINGING FUNCTIONS

// two ways of defining a function:
string concat(string message, string prefix) {          // return-type name(parameters)
    return prefix + message;                            // return expression
}

//or, from C++11 onwards... 
auto _concat(string message, string prefix) -> string {
    return prefix + message; 
}

// the second form is a little more logical: 
// concat is the function which takes two strings to a single string
// or,  (string, string) -> string

// even so, the first is more idiomatic for simple defintions of this kind


// functions need not return a value, and if so, must be declared void:
void print(string message) { cout << message << endl; }

// functions need not accept arguments, and if so, may leave the argument list empty or with a single void:
string get_username(void) { return "michael"; }
string get_location() { return "UK"; }                  //NB. in C the first form is required


// DEFAULT ARGUMENTS


//functions may have default arguments, if they do, those arguments must be last in the parameter list
void error_message(string message, string prefix="ERROR: ") {
    print(concat(message, prefix));      // function calls (to non-void functions) are expressions 
}                                        // their evaulation is their return value, which can be passed around like any other

int main(void) {

    print(get_username());
    error_message("A Sample Error!");

    return 0;
}


/* OUTPUT (notes/13.function-defintion.cpp):
michael
ERROR: A Sample Error!

*/