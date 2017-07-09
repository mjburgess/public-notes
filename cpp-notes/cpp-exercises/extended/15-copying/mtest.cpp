
//======================================================================
//
//  Filename:     mtest.cpp
//  Description:  Simple test harness to exercise the matrix class.
//
//======================================================================

#include <iostream>
using namespace std;
#include "matrix.hpp"                    // matrix class definition

int main()
{
    int r, c;

    cout << "Enter matrix dimensions, #rows  x  #cols... ";
    cin  >> r >> c;

    matrix m(r, c);                      // Create a matrix object
    m.input_values();                    // Ask user for matrix values

    matrix copy1 = m;                    // Uses the matrix copy constructor
    matrix copy2(m);                     // Also uses the copy constructor

    m = copy1 + copy2;                   // Calls matrix::operator+ to add
                                         // the two matrices together, then
                                         // calls the assignment operator to
                                         // store the answer in "m"
                                         
    m = m;                               // What happens if you try assigning
                                         // an object to itself?

    m.display();                         // Display the matrix objects
    copy1.display();
    copy2.display();

	
	cout << "m is" << ((bool)m?" ":" not ") << "a square matrix" << endl;
	

    return 0;
}    
