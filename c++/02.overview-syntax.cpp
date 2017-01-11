#include <iostream>
#include <limits>

using namespace std;

int main(void) {
    // expressions == any valid syntax phrase which evaluates (ie. has a value)
    //eg.,  1 + 2

    // statement == any valid syntax phrase which has no value

    int age = 18 + 30;      //whole line is a statement (varaible declaration)
                            // 18 + 30 is an expression

    //declaration is a type of statement == effect is to introduce an identifier into scope
    int xDistance, yDistance;       // this line has no value, so it is a statement
                                    // all declarations need a semi-colon! (easy to forget with classes..)

    //however assignment is an *expression* -- the value of an assignment is the value being assigned
    cout << "x is " << (xDistance = 1) << " and y is " << (yDistance = 2) << endl;

    int apples = 5, oranges = 10, cherries = 20;

    //gasp! assignment is an *expression*
    (apples = oranges) = cherries;

    // (x = y) evals to x after assigning y  
    // -- expression has an rvalue meaning (value of x) and an lvalue meaning (identifer x)

    cout << apples << "a " << oranges << "o " << cherries << "c" << endl;
    
    int people = 10;        //*variables* have types -- their contents, held in memory, is just some bit pattern
    int busLoad = 20;       //types tell the *compiler* how to understand this bit pattern
                            // and how to formualte the bit pattern when creating the value (eg. int 0 is unlike long 0)
    
    //new-value  =  old-value + delta
    people  = people + busLoad;

    people += busLoad; // add busLoad to people
    people /= 5;       // divide people by 5

    cout << "there are " << people << " people" << endl;

    int days;

    cout << "how many days: ";
    
    days = 5;
    // OR:   cin >> days;

    const int day_seconds = 24 * 60 * 60;           //compile time
    const int total_seconds = days * day_seconds;   // run-time, depends on days

    cout << endl << "entered: " << days << ", total seconds " << total_seconds << endl;

    /*
        require some discussion of lvalues, rvalues, etc.

    */


    // the C++ compiler needs to know how to layout values in memory 
    // this can be inferred from the type: 
    long populationL = 1;
    int populationI = 1;
    char populationC = 1;

    cout << "the bit pattern for char(1) is " << bitset<sizeof(char) * 8>(populationI) << endl; 
    cout << "the bit pattern for int(1) is " << bitset<sizeof(int) * 8>(populationI) << endl;
    cout << "the bit pattern for long(1) is " << bitset<sizeof(long) * 8>(populationL) << endl;

}


/* OUTPUT (notes/02.overview-syntax.cpp):
x is 1 and y is 2
20a 10o 20c
there are 10 people
how many days: 
entered: 5, total seconds 432000

*/