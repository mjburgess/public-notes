
// Chapter:     Object Relationships
// File:        venue.cpp
// Description: Member definitions for venue class

#include "venue.hpp"

venue::venue(const string & nm, const string & c)
	: placename(nm)
	, city (c)
{
	// all done
}


string venue::get_venue_details() const
{
    return (placename  +  ", "  +  city);
}
