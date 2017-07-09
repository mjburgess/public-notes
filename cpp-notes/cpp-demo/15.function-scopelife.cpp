#include <iostream>
using namespace std;
// SCOPE

// when the compiler reads the file it treats different reigions of the file uniquely
// the outer most level is called the gloabl scope and any identifer defined here uniquely belongs to this region

int total = 0;      // the fullname of this identifier is ::total
                    // the :: prefix is the global namespace, the prefix of all global variables

void increment() {
    int total = 5;      // this total belongs to the scope of the increment function (the reigion inbetween braces)

    ::total += total;   //here, then, we add the *local* total to the *global* total
    
    // variables defined in the outermost scope are accessible in the inner scope
    // however we can *shadow* variables...

    {                                       // < . this reigion is its own scope, meaing
        int total = 10;                     //   . this identifier belongs to this reigion alone
        ::total += total;                   //   . here then, we add 10 to the global total
    }                                       // < . 

    // in this reigion the identifier 'total' refers to the function's total
}


// the increment function has a strange quirk: 
// it adds to the global total, affecting the global value 
// our intutions say that functions should *return* their values, and any value not returned, is inaccessible
// globals break this expectation... they can be modified surrupticiously by the function 

// this suggests something strange about global variables: they have a special *lifetime* -- they live for the entire program 
// whereas, say, the parameters of functions only keep their values while the function is being run, afterwards they are cleared away



// LIFETIME
// the static keyword can be used to give a variable local to a function (ie. accessible only within a function's scope)
// a global lifetime (ie., one which persists for the duration of the entire program)


int count() {           
    static int call_count = 0;           //each time count() is called, call_count increases by 1
    return ++call_count;

    //NB. the variable call_count is defined only within this function, but its value persists across function calls
    // so that the each time count() is called, call_count retains its last value
}



// SCOPE & REFERENCES

//functions may recieve their arguments by-copy, or by-reference

void addByVal(int x, int y) {        // when add() is called the values "passed" as arguments are actually
      x += y;                        // *copied* into the varibles x and y for the lifetime of the function call
}                                    // the variables x and y are local to the function

void addByRef(int &x, int y) {      // here x is passed by-reference, 
    x += y;                         // x becomes *an alias* for whatever variable is actually passed when the function gets called
}                                   // x is then just another name for a variable that is defined outside this function
                                    // which lives longer than this function call


int main(void) {
    int myX = 10, myY = 20;
    cout << "x = " << myX << ", y =" << myY << endl;

    addByVal(myX, myY);       // no effect -- nothing returned
    cout << "x = " << myX << ", y =" << myY << endl;
    
    addByRef(myX, myY);
    cout << "x = " << myX << ", y =" << myY << endl;    // myX changes!
    
    //here addByRef has managed to grab hold of myX and change it 
    //unlike addByVal which is only given a copy of myX and has no access to the original 

    // OTHER EXAMPLES

    cout << count() << endl;
    cout << count() << endl;
    cout << count() << endl;

    cout << "total = " << total << endl;
    increment();
    cout << "total = " << total << endl;


    return 0;
}

// this section discusses ways functions can break our usual expectation, which is:
// new_value = operation(old_value);

// that is:
//1. changes occur due to assignment (=); 
//2. values are passed into functions as arguments; 
//3. and the only way they get out is by being returned

// these are three excellent principles and lead to very clear program design which is easy to reason about

// globals break these by allowing "hidden parameters" that can be changed without returning a value
// these created hidden dependences across multiple functions which are hard to identity and reason about 
// they lead to unessarily complex code

// references break principle (1) -- many do not care about this failure as it has many benefits for making OOP programming easier
// nevertheless in procedural programming they should be last restorts... learn to love the clarity of new = f(old)

//Q. how do static variables affect (1 - 3)?


// FINALLY:   see the samples/procedural   sample project for another use of the keyword 'static'


/* OUTPUT (notes/15.function-scopelife.cpp):
x = 10, y =20
x = 10, y =20
x = 30, y =20
1
2
3
total = 0
total = 15

*/