
//======================================================================
//
//  Filename:     money.cpp
//  Description:  Implementation of a money class
//
//======================================================================

#include <iostream>                           // Stream class definition
using namespace std;
#include "money.hpp"                          // money class definition


money::money(double m)  // Constructor
	: amount(m)            
{
	// all done
}

                                  
money & money::operator+=(const money & rhs) // Add amount to object
{
    amount += rhs.amount;
    return *this;
}


money & money::operator-=(const money & rhs) // Subtract amount from object
{
    amount -= rhs.amount;
    return *this;
}


void money::display() const                   // Display money value   
{
    cout << "$ " << amount << endl;
}
