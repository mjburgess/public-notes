
// Chapter:     Object Relationships
// File:        conf.hpp
// Description: Class definition for conference

#ifndef CONFERENCE_INCLUDED
#define CONFERENCE_INCLUDED

#include <string>
#include <vector>
#include <iostream>
#include "person.hpp"
#include "venue.hpp"

using namespace std;

class conference
{
public:

    conference(const string & nm, int d);   // Constructor

    void set_venue(venue * pv);             // Set pointer to point to specific venue object
    void cancel_venue();                    // Reset pointer to zero, i.e. "no venue"
    void register_person(person * pp);      // Add specified person to list of attendees
    void display() const;                   // Display all details about the conference

private: // state

    string conference_name;         // Name of conference, eg "Swansea City AGM"
    int    duration;                // How many days does the conference last

    venue * pvenue;                 // Pointer to venue, where the conference is taking place
	vector<person *> attendees;     // List of people who have registered to attend

};

#endif
