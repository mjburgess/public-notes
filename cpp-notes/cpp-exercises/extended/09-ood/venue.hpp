
// Chapter:     Object Relationships
// File:        venue.hpp
// Description: Class definition for venue

#ifndef VENUE_INCLUDED
#define VENUE_INCLUDED

#include <string>

using namespace std;

class venue
{
public:

    venue(const string & nm, const string & c);	// Initialise place-name and city
    string get_venue_details() const;			// Display place-name and city of venue

private: // state

	string placename;				// Place-name, e.g. "Earls Court"
	string city;					// City, e.g. "London"

};

#endif
