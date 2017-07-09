
// Chapter:     Object Relationships
// File:        useconf.cpp
// Description: Conference management system

#include <iostream>
#include <string>
#include <vector>

#include "conf.hpp"
#include "person.hpp"
#include "venue.hpp"

using namespace std;

int main()
{
	// Create a "conference" object ...
    conference big_event("Swansea City Supporters Club AGM", 4);
	
	// Create 3 venue objects, representing 3 different venues
	venue seaside_venue("The Pier", "Aberystwyth");
	venue country_venue("Tithe Barne", "Brecon");
	venue exotic_venue ("Hotel Nirvana", "Tahiti");

	// Create a vector of persons (for the OPTIONAL questions)
	vector<person> people;
	people.reserve(20);

    bool running = true;
    while (running)
    {
        cout << endl << "Please enter option"
			 << endl << "(seaside, country, exotic, display, cancel, add, register, exit): ";
        string response;
        cin >> response;

		if (response == "seaside")
		{
			big_event.set_venue(&seaside_venue);
		}
		else if (response == "country")
		{
			big_event.set_venue(&country_venue);
		}
		else if (response == "exotic")
		{
			big_event.set_venue(&exotic_venue);
		}
		else if (response == "cancel")
		{
			big_event.cancel_venue();
		}
		else if (response == "display")
		{
			big_event.display();
		}
        else if (response == "add") 
        {
            cout << "Please enter first and last name for person number "
                 << people.size() << ": ";
            people.resize(people.size() + 1);
            people.back().read();
        }
        else if (response == "register")
        {
            cout << "Please enter the person's number: ";
            size_t person_id;
            cin >> person_id;

            if (person_id < people.size())
            {
                big_event.register_person(&people[person_id]);
            }
            else
            {
                cerr << "Error: no such person" << endl;
            }
        }
        else if (response == "exit")
        {
            running = false;
        }
    }

    return 0;
}
