#include <iostream>
#include <string>
using namespace std;

struct Person { string name; };
void print_person(Person *p) { cout << (*p).name << endl; }


int main(void) {
    //POINTERS

    int population = 1000;
    int *ptrPop = &population;
    *ptrPop = 2000;

    cout << "the population is " << population << endl;
    cout << "ptrPop is " << long(ptrPop) << ", often written " << ptrPop << endl;

    //how does this work?
    //the mechanism is easy enough to explain, if the syntax is a little hard to understand:

    //population holds the value of 1000
    //ptrPop hold the address of the location where population is stored   (&population) 
    //we modify population by using its address: "go to wherever this address points to, and update its value to 2000"

    /* in pseduo-code:

        set A to 1000
        set pA to addressof-A
        set at-pA to 2000

        ie., set at-addressof-A to 2000
        ie., set A to 2000 
    */

    //a pointer is a number, like any other -- like char, like int, like short
    //however we tell the compiler that this number should be understood to be an address in its type

    int *ptr = ptrPop;  // the *type* of ptr is  (int *) meaning "a pointer to an int"
                        // recall: variables have types -- compiler labels -- not their contents
                        // here the type informs the compiler that this number is a place in memory
                        
    //note the position of the star (*):  its in the type!


    //now the star appears as part of an expression -- the RHS of an assignment
    int pop = *ptrPop;

    //the type of pop is integer
    //the type of *ptrPop is integer

    // * in an expression means "dereference", i.e. lookup the value
    // so pop stores the value at the address of ptrPop, ie. the population

    cout << "the address of population is " << &population << endl;         // & on an identifier means addressof
    cout << "the value at this address is " << *(&population) << endl;      // so *(&x) means x

    //let's look at a more complex example:

    string name = "Michael";
    string *pName = &name;
    string *pUser = pName;

    *pUser = "Sherlock";

    cout << "the username is " << name << endl;

    //let's diagram this:

    /*  
         ._______.
         |       |
name @1  |Michael|      name at address-1 holds "Michael"
         ._______.
         ._______.
         |       |
pName @2 |   @1  |      pName at address-2 holds address-1
         ._______.
         ._______.
         |       |
pUser @3 |   @1  |      pUser at address-3 holds address-1
         ._______.

    */ 

    //NULL 

    //nullptr (C++11) is a strongly-typed 0 value that can only be used to initialize pointers:
    string *location = nullptr;
    
    //it means "without a value", ie. that there is no adress location can point to 
    //recall: unitilizated variables can have abitary values -- nullptr is a sensible default

    //it allows you to write:

    if(location) {          //nullptr is false
        cout << location << endl;
    } else {
        cout << "location was null" << endl;
    }


    // POINTERS & STRUCTs
    Person sherlock { "Sherlock Holmes" }; 
    Person *pSherlock = &sherlock;
    
    //we access parts of a struct using the dot-notation:
    cout << "sherlock's name is" << sherlock.name << endl;

    //however if we have a pointer to a struct, we would write:
    cout << "sherlock's name is " << (*pSherlock).name << endl;  //NOTE:  parenthese required! otherwise it assumes *(s.x) 

    //BUT, since pointers to structs are quire common, there is a more convenient syntax:
    cout << "sherlock's name is " << pSherlock->name << endl;

    //whenever you see an arrow like this   x->y   the LHS is a pointer and the RHS is some field of the value pointed-at



    // WHY POINTERS?

    //1. dynamic memory

    //if you have hold of some memory:
    int i = 10;                         

    //then it might seem a little pointless to get an address of it.. 
    int *pI = &i;

    //and in this case you'd be right!
    // (here the *compiler* makes sure there's a bit of memory called i, holding 10 )

    //however often in C++ programming you won't have the original bit of memory in-hand to get the address:
    //you will be *given* an address (eg. by the operating system)

    char *tenchars = (char *) malloc(10 * sizeof(char)); //malloc gives you an address where's theres 10 bytes free
                                                         //there isnt an original varibale to take the addressof  

    // dynamic memory allocation is used to request memory at run-time
    // eg. based on some cin >>  variable (say, number of items in a basket to allocate)
    // since this amount of items a customer has changes each run of the program, 
    // the amount of memory requred changes 

    //most programs require dynamic memory in this way, and so pointers are essential
    //there is no predictable amount memory the compiler can allocated for you, ahead of time

    //2. saving memory 
    //another use of pointers is to save the compiler from allocating lots of extra memory...
    //recall: the arguments to a function are passed-by-copy

    Person me { "Michael" }; //imagine the struct had lots of fields, or eg. contained 1GB of file contents
    Person *pMe = &me;

    cout << "the struct me weighs " << sizeof me << " bytes" << endl;
    cout << "the pointer to me weighs " << sizeof pMe << " bytes" << endl;

    print_person(pMe);  // when we pass the pointer, the pointer is copied
                    // *not* the struct
                    // so print_me can see the original struct without it being copied
                    // how does it see the original?  *pMe !

    //3. data structures
    // ARRAYS

    int ages[] {18, 19, 20, 65};

    // the identifier 'ages' is a actually pointer to the first element of the ages array...
    cout << "the first age is " << *ages << " == " << ages[0] << endl;
    cout << "the second age is " << *(ages + 1) << " == " << ages[1] << endl;
    
    // "an array" is therefore just a reigion of memory where values occur in sequence
    // by knowing the address of the first value we can find each subequent array element "one value along"
    
    // the subscript operator x[n] just means *(x + n) -- ie., deference the address n items along from the address x
    //NOTE: this is a special kind of addition, called pointer arithmetic
    //the full equation is  (x + sizeof(*x) * n) ie., what it means to be "n items along" is to be n * the-sizeof-one-item along
    //+ and - when used with pointers are *not* integer addition, +1 is actually a leap of the sizeof the data pointed to

    // ARRAYS of POINTERS
    Person *people[] = { &me, &me, &me };   // array of pointers to structs

    //very easy to move element around:
    people[1] = people[0];  //copies pointer, rater than struct

    // and many other data structures (eg. deques, linked lists, etc.) hold pointers to their items
    // rather than their items... so they are easier to sort, and manipulate without causing lots of memory to be moved around

}


/* OUTPUT (notes/17.types-pointers.cpp):
the population is 2000
ptrPop is 140734601201864, often written 0x7fff53e988c8
the address of population is 0x7fff53e988c8
the value at this address is 2000
the username is Sherlock
location was null
sherlock's name isSherlock Holmes
sherlock's name is Sherlock Holmes
sherlock's name is Sherlock Holmes
the struct me weighs 24 bytes
the pointer to me weighs 8 bytes
Michael
the first age is 18 == 18
the second age is 19 == 19

*/