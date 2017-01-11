#include <iostream>

using namespace std;

int main(void) {  
    //ARRAYS -- compile-time sized sequences of values of a particular type (ie. homogenous)
    double heights[5] = {1.6, 1.65, 1.7, 1.81, 1.79};       // aggregate initializer cf. initializer of int x = 0
    double ages = {0};
    double weights[5] = {80, 70, 60, 80, 90};


    // acceed by subscript operator, []
    int index;

    cout << "pick a person (0 - 4):";
    
    index = 3;
    //OR: cin >> index;

    cout << "their bmi is " << (weights[index] / ( heights[index] * heights[index])) << endl;


    // the identifier heights does *not* refer to the entire array...
    // it refers to the *memory* location of the first element of the array
    //operations which affect more than one element at a time need to either call functions or use loops


    // LOOKUP TABLES

    const int days_in_month[] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    //const == cannot be modified
    
    //DOWNSIDES:
    // no easy io for arrays (in general) -- may need to write your own functions 
    // size fixed at compile time
    // nothing checked (eg. indexes can be accessed out of bounds)


}


/* OUTPUT (notes/08.types-arrays.cpp):
pick a person (0 - 4):their bmi is 24.4193

*/