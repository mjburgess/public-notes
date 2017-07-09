
// Chapter:     Implementing Classes
// File:        room.hpp
// Description: Class definition for simple day bookable room

#ifndef ROOM_INCLUDED
#define ROOM_INCLUDED

#include <string>
#include <iostream>
using namespace std;
#include "bookings.hpp"



class room
{
public:

    room(const string &);
        // initialises room with its name and no bookings

    bool book(const date &, const string &);
        // returns true if successfully booked

    bool cancel(const date &);
        // returns true if there was a booked date to be cancelled

    void query() const;
        // prints all details bookings to cout

private: // state

    string   label;
    bookings day_bookings;

};

#endif
