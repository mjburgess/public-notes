
//======================================================================
//
//  Filename:     matrix.hpp
//  Description:  Definition of the matrix class
//
//======================================================================

#ifndef MATRIX_INCLUDED
#define MATRIX_INCLUDED

#include <iostream>
#include <string>

using namespace std;

class matrix
{
public:
    //========Your functions============================================

    matrix(int r, int c);                        // Constructor
    matrix(const matrix & rhs);                  // Copy constructor
    matrix & operator=(const matrix & rhs);      // Assignment operator
   ~matrix();                                    // Destructor

    matrix operator+(const matrix & rhs) const;  // Overload + operator
    matrix operator-(const matrix & rhs) const;  // Overload - operator

    void input_values();                         // Input  matrix values
    void display() const;                        // Output matrix values

    explicit operator bool () const;						// True if square matrix


private: // state

    int   rows, cols;          // Number of rows and columns
    int * pdata;               // Pointer to array of integers in matrix
};

#endif
