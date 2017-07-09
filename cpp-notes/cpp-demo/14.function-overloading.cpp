#include <iostream>

using namespace std;

// functions may be overloaded meaning that the same identifer may polymorphically 
// (depending on the type of its parameters) refer to different concrete operations

// GOAL: define a print function which outputs the value and type of its argument 
void print(int i) { cout << "integer: " << i << endl; }
void print(bool i) { cout << boolalpha << "boolean: " << i << endl; }
void print(double i) { cout << "double: " << i << endl; }
void print(string i) { cout << "string: " << i << endl; }


//GOAL: define a concat operation which joins two values of the same type together
int concat(int x, int y) { return x + y; }
bool concat(bool x, bool y) { return x && y; }
string concat(string x, string y) { return x + y; }

/* interesting extras:

string concat(const char *x, const char *y) { return string(x) + string(y); }  //fixes the problem below
string concat(string x) { return "Mr. " + x; }                              //different parameter number

*/


int main(void) {

    print(concat(1, 2));
    print(concat(true, false));
    print(concat("Ms. ", "Jane"));                  //this selects concat(bool, bool)  ! 
    print(concat(string("Ms. "), string("Jane")));

    return 0;

    // NB. recall: the type of literal strings, eg. "Mr. ", is const char *   
}


// overloaded functions interact with default parameters..

void write() { cout << "message"; }
void write(int x) { cout << "message"; }
void write(int x, int y) { cout << "message"; }

/* but not:

bool write(int x) { cout << "message"; return true; }
void write(int x, int y=0) { cout << "message"; }


// why? -- which function does write(5) call?

*/

// EXTRA 1:

// Q. which other operation here is overloaded?
// A. <<

// EXTRA 2:

// in what sense is concat the same operation in each case?

// concat(T, T) -> T  where there exists concat(v, 0) == v 
// for every value v of type T, where 0 is a zero-value of that type

// Q. what is the zero value of the boolean type for the concat operation?

// ASIDE: types of this kinds are called monoids 


/* OUTPUT (notes/14.function-overloading.cpp):
integer: 3
boolean: false
boolean: true
string: Ms. Jane

*/