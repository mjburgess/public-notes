
// Chapter:     Implementing Classes
// File:        bookings.cpp
// Description: Member definitions for class bookings

#include "bookings.hpp"

bool bookings::booked(const date & when) const
{
    bool found = false;

    for (size_t position = 0; !found && position < entries.size(); ++position)
    {
        if (entries[position].when.day_in_year() == when.day_in_year() &&
           entries[position].when.year() == when.year())
        {
            found = true;
        }
    }

    return found;
}


bool bookings::add(const date & when, const string & who)
{
    bool made_booking = false;

    if (!booked(when))
    {
        booking new_entry;
        new_entry.when = when;
        new_entry.name = who;

        entries.push_back(new_entry);
        made_booking = true;
    }

    return made_booking;
}


bool bookings::remove(const date & when)
{
    bool removed = false;

    // search for position, if any, with same date
    for (size_t position = 0; !removed && position < entries.size(); ++position)
    {
        if (entries[position].when.day_in_year() == when.day_in_year() &&
           entries[position].when.year() == when.year())
        {
            // overwrite the found booking with the last booking
            entries[position] = entries.back();
            
            // remove the copy of the last booking
            entries.pop_back();

            removed = true;
        }
    }

    return removed;
}


void bookings::list() const
{
    for (size_t position = 0; position < entries.size(); ++position)
    {
        entries[position].when.write();
        cout << " booked by " << entries[position].name << endl;
    }
}
