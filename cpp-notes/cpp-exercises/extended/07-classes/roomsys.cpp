
// Chapter:     Implementing Classes
// File:        roomsys.cpp
// Description: Room booking system

#include <iostream>
#include <string>
#include "room.hpp"
#include "date.hpp"

using namespace std;

int main()
{
    bool running = true;
    room location("Meeting Room 101");

    while (running)
    {
        cout << "Please enter option (book, cancel, query, exit): ";
        string response;
        cin >> response;
        date when;

        if (response == "book")
        {
            cout << "In what name and for what date? (name dd mm yyyy) ";
            cin >> response;
            when.read();

            if (!location.book(when, response))
            {
                cout << "Sorry, already booked for that date" << endl;
            }
        }
        else if (response == "cancel")
        {
            cout << "What date? (dd mm yyyy) ";
            when.read();

            if (!location.cancel(when))
            {
                cout << "Nothing to cancel on that date" << endl;
            }
        }
        else if (response == "query")
        {
            location.query();
        }
        else if (response == "exit")
        {
            running = false;
        }
    }

    return 0;
}
