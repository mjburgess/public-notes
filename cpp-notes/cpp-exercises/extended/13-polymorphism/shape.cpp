
//======================================================================
//
//  Filename:     shape.cpp
//  Description:  Implementation of the shape hierarchy
//
//======================================================================

#include <cmath>                            // abs() and sqrt() functions
#include <iostream>                         // Stream class library
using namespace std;
#include "shape.hpp"                        // shape  class hierarchy

//======================================================================
// shape base class functions
//======================================================================

const double pi = 3.14;

shape::shape(int x0, int y0, int x1, int y1)
	: left(x0),  top(y0)
	, right(x1), bottom(y1)
{
	// all done
}


shape::~shape()
{
	// all done
}


void shape::display_coords() const
{
    cout << "Coordinates: (" << left    << ", "
                             << top     << ", "
                             << right   << ", "
                             << bottom  << ")\n"; 
}                  


void shape::translateX(int dx)
{
    left  += dx;
    right += dx;                                         
}


void shape::translateY(int dy)
{
    top    += dy;
    bottom += dy;                                         
}


double shape::area() const
{
    return abs(right - left) * abs(bottom - top);
}


//======================================================================
// circle functions
//======================================================================

circle::circle(int cx, int cy, int rad) 
	: shape(cx-rad, cy-rad, cx+rad, cy+rad)
{
	// all done
}

        
circle::~circle()
{
    cout << "circle destructor" << endl;
}

        
double circle::area() const     
{
    int radius = (right - left) / 2;
    return pi * radius * radius;
}


double circle::perimeter() const     
{
    int radius = (right - left) / 2;
    return 2 * pi * radius;
}


//======================================================================
// parallelogram functions
//======================================================================

parallelogram::parallelogram(int x0, int y0, int x1, int y1, int dx) 
	: shape(x0, y0, x1, y1)
	, delta(dx)
{
	// all done
}


parallelogram::~parallelogram()
{
    cout << "parallelogram destructor" << endl;
}
                         
                         
double parallelogram::area() const
{
    int base   = abs(right - left - delta);
    int height = abs(bottom - top); 
    
    return base * height;
}


double parallelogram::perimeter() const
{
    int base   = abs(right - left - delta);
    int height = abs(bottom - top); 
 	double sum = (height * height) + (delta * delta);
 
	return 2 * (sqrt(sum)+ base);
}


//======================================================================
// rectangle functions
//======================================================================

rectangle::rectangle(int x0, int y0, int x1, int y1) 
	: parallelogram(x0, y0, x1, y1, 0)
{
	// all done
}


rectangle::~rectangle()
{
    cout << "rectangle destructor" << endl;
}
