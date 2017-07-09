
// Chapter:     Object Relationships
// File:        person.cpp
// Description: Member definitions for person class

#include <iostream>
using namespace std;
#include "person.hpp"

void person::read()
{
    cin >> first_name >> last_name;
}


string person::get_fullname() const
{
    return first_name + " " + last_name;
}
