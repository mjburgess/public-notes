
// Chapter:     Object Relationships
// File:        conf.cpp
// Description: Member definitions for conference class

#include "conf.hpp"


conference::conference(const string & nm, int d)
	: conference_name(nm)
	, duration(d)
	, pvenue(0)
{
	// all done
}


void conference::set_venue(venue * pv)
{
	pvenue = pv;
}


void conference::cancel_venue()
{
	pvenue = 0;
}


void conference::register_person(person * new_attendee)
{
    attendees.push_back(new_attendee);
}


void conference::display() const
{
    cout << endl << conference_name 
		 << " (" << duration << " days) is being held at ";

    if (pvenue != 0)
    {
        cout << pvenue->get_venue_details() << endl;
    }
    else
    {
        cout << "unspecified venue" << endl;
    }


    cout << "List of registered attendees:" << endl;

    for (size_t current = 0; current < attendees.size(); current++)
    {
        cout << '\t' << attendees[current]->get_fullname() << endl;
    }
}
