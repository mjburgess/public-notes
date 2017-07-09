
//======================================================================
//
//  Filename:     money.hpp
//  Description:  Definition of a money class
//
//======================================================================

#ifndef MONEY_INCLUDED
#define MONEY_INCLUDED

class money
{
public:
    money(double);                          // Constructor  
    
    money & operator+=(const money & rhs);  // Add amount to object
    money & operator-=(const money & rhs);  // Subtract amount from object

    void display() const;                   // Display money value

private: // state

    double amount;
};

#endif
