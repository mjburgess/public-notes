
// Chapter:     Object Relationships
// File:        person.hpp
// Description: Class definition for person

#ifndef PERSON_INCLUDED
#define PERSON_INCLUDED

#include <string>

using namespace std;

class person
{
public:

    void read();					// Read first and last name in from cin
    string get_fullname() const;	// Return full name

private: // state

    string first_name;
	string last_name;

};

#endif
