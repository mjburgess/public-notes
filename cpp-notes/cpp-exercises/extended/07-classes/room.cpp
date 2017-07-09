
// Chapter:     Implementing Classes
// File:        room.cpp
// Description: Member definitions for room class

#include "room.hpp"

room::room(const string & name)
  : label(name)
{
	// all done
}


bool room::book(const date & when, const string & who)
{
    return day_bookings.add(when, who);
}


bool room::cancel(const date & when)
{
    return day_bookings.remove(when);
}


void room::query() const
{
    cout << "Bookings for " << label << ':' << endl;
    day_bookings.list();
}
