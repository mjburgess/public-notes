
// Chapter:     Functions
// File:        usedate.cpp
// Description: Test harness for date handling functions

#include <iostream>
#include <string>
using namespace std;
#include "date.hpp"


int main()
{
    string response;

    do
    {
        // query date
        date when;
        do
        {
            cout << "Please enter a date (dd mm yyyy): ";
        }
        while (!read(when));

        // present results
        cout << "The date entered was ";
        write(when, verbose);
        cout << endl;

        // query for continuation
        cout << "Do you wish to enter another date? ";
        cin >> response;
    }
    while (response[0] == 'Y' || response[0] == 'y');

    return 0;
}
