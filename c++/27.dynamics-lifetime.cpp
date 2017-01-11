#include <iostream>
using namespace std;

// static  == for entire duration of the program ("unmoving, always in place")
// stack   == for duration of the function call  ("on the call stack")   
// dynamic == for some moments during the program ("changing")

// global         == visible in every file 
// file-local     == visible in this file
// function-local == visible in the function
// block-local    == visible in the block


                                //           STORAGE       SCOPE
int populaton = 1000;           //           static        global

static int myPopulation = 10;   //           static        file 

int getPopulation() {
    int localPopulation = 5;    //           stack         function
    int *theirPop = new int;    //           dynamic       function
    {   
        int localPopulation = 10;
    }

    for(int thisPop = 0; thisPop < 5; thisPop++) {  // thisPop: stack   block
        return thisPop + localPopulation;
    }
}   //Q. what does this function return?


// CONCEQUENCES (lifetime shorter than expected = fail; & longer = leak)
int returningStatic() {
    return population;
}

int returningStack() {
    int local = 10;
    return local;
}

int *returningStackPtr() {
    int local = 10;
    return &local;
}

int *returningDynPtr() {
    int *local = new int;
    *local = 10;
    return local;
}

//Q. which of the above have a problem?

int main(void) {
    cout << "the population is " << getPopulation() << endl;
    return 0; 
}


/* OUTPUT (notes/27.dynamics-lifetime.cpp):
TODO

*/