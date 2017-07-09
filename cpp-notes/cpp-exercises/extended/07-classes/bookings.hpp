
// Chapter:     Implementing Classes
// File:        bookings.hpp
// Description: Class definition for day bookings class

#ifndef BOOKINGS_INCLUDED
#define BOOKINGS_INCLUDED

#include <string>
#include <vector>
#include <iostream>

#include "date.hpp"

using namespace std;

struct booking
{
    date   when;
    string name;    
};

class bookings
{
public:

    bool booked(const date &) const;
        // returns true if the date is already booked out

    bool add(const date &, const string &);
        // returns true if successfully booked date in given name

    bool remove(const date &);
        // returns true if removed given date

    void list() const;
        // lists the current bookings to cout

private: // state

    vector<booking> entries;

};

#endif
