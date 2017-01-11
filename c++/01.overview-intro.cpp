//comment

#include <iostream> // preprocessor directive, c++ io library
#include <stdio.h>  // c io library

using namespace std;        //to remove name (identifier) prefixes known as namespaces
                            // -- many identifers in c++ library header files have a std:: prefix.

int main(int argc, char **argv) {           // this function is called by the operating system
    puts("Hello World!");                   // function call to C-library

    cout << "Hello World" << endl;          //endl == newline constant
    // << is an operator on the cout object which comes from C++ library

    //compare with:
    std::cout << "Hello World" << std::endl;        // the std:: prefix is part of the full name of the identifers


    /* 
        comments can also span
        multiple lines
    */

    cout << "enter your age: ";

    int age;
    auto birthday = 1;          // c++11 declaration -- Q. why is initializer required? for auto.

    // cin >> age;
    age = 18;
    cout << "next year you will be " << age + birthday << " years old!" << endl;

    //cout's << works with strings and numbers -- operator polymorphism (?)

    return 0; //end of program
}

/* QUESTIONS

Literals?
Keywords?
Identifiers?
Operators?



Compounds: Expressions, Statements, Declarations

Q. Is return a valid identifier? 
*/



/* MORE OBSERVATIONS:

free form (vs. off-side rule & puncard languages)
    readability is important

vertical and horizontal spacing
one statement per line

*/


/* OUTPUT (notes/01.overview-intro.cpp):
Hello World!
Hello World
Hello World
enter your age: next year you will be 19 years old!

*/