
//======================================================================
//
//  Filename:     matrix.cpp
//  Description:  Implementation of matrix class.
//
//======================================================================

#include <iostream>                              // Stream library
using namespace std;
#include "matrix.hpp"                            // matrix class

//========Your functions================================================

matrix::matrix(const matrix & rhs)                // Copy constructor
	: rows(rhs.rows)
	, cols(rhs.cols)
	, pdata(new int[rhs.rows * rhs.cols])
{                                                
//  cout << "\nCopy constructor called";

    for (int i = 0; i < rows * cols; ++i)        // Copy matrix items
	{
        pdata[i] = rhs.pdata[i];                
	}
}


matrix & matrix::operator=(const matrix & rhs)  // Assignment operator
{                                              
//  cout << "\nAssignment operator called";
    
    if (this != &rhs)                            // Assignment to self?
    {
        delete[] pdata;                          // Delete old matrix data

        rows  = rhs.rows;                        // Copy in new data (same
        cols  = rhs.cols;                        // as copy constructor)
        pdata = new int[rows * cols];            // Allocate array for data

        for (int i = 0; i < rows * cols; ++i)    // Copy matrix items
		{
            pdata[i] = rhs.pdata[i];                
		}
    }
    return *this;                                // Return ref. to self
}


/* 
 * alternative version of assignment operator
 * Exception safe, and self-assignment safe
 *
matrix & matrix::operator=(const matrix & rhs)
{                                              
	int * new_pdata = new int[rhs.rows * rhs.cols];
    for (int i = 0; i < rhs.rows * rhs.cols; ++i)
	{
		new_pdata[i] = rhs.pdata[i];
	}
	int * old_pdata = pdata;
	pdata = new_pdata;
	rows = rhs.rows;
	cols = rhs.cols;
	delete[] old_pdata;
	return *this;
}
*/

//========Pre-written functions=========================================

matrix::matrix(int r, int c)
	: rows(r)
	, cols(c)
	, pdata(new int[r * c])
{                                              
//  cout << "\nNormal constructor called";
}


matrix::~matrix()                                // Destructor
{                                              
//  cout << "\nDestructor called";
    delete[] pdata;                             // Delete the data array
}


matrix matrix::operator+(const matrix & rhs) const
{
//  cout << "\n\nOperator+ called";
    matrix result(rows, cols);

    for (int i = 0; i < rows * cols; ++i)
	{
        result.pdata[i] = this->pdata[i] + rhs.pdata[i];
	}

    return result;
}


matrix matrix::operator-(const matrix & rhs) const
{
//  cout << "\n\nOperator- called";
    matrix result(rows, cols);

    for (int i = 0; i < rows * cols; ++i)
	{
        result.pdata[i] = this->pdata[i] - rhs.pdata[i];
	}

    return result;
}


void matrix::input_values()                      // Input matrix values
{
    cout << "\nPlease enter initial values ...\n";
    for (int r = 0; r < rows; ++r)            
    {   
        cout << "Row " << r << "... ";
        for (int c = 0; c < cols; ++c) 
        {    
            cin >> pdata[r*cols + c];
        }
    }
}


void matrix::display() const                     // Output matrix values
{
    cout << "\n\nDisplaying matrix items ...";

    for (int r = 0; r < rows; ++r)
    {   
        cout << "\nRow " << r << ": ";
        for (int c = 0; c < cols; ++c)
        {
            cout << pdata[r*cols + c] << ' ';
        }
    }
	cout << endl;
}

matrix::operator bool() const
{
	return (this->cols == this->rows);
}

