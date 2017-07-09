
// Chapter:     Control Flow
// File:        leapyear.cpp
// Description: Classify whether a year is a leap year

#include <iostream>
#include <string>

using namespace std;

int main()
{
    string response;

    do
    {
        // query year
        cout << "Please enter a year: ";
        int year;
        cin >> year;

        // present results
        if (year % 4 == 0 && (year % 400 == 0 || year % 100 != 0))
        {
            cout << year << " is a leap year" << endl;
        }
        else
        {
            cout << year << " is not a leap year" << endl;
        }

        // query for continuation
        cout << "Do you wish to enter another year [Yes | No]? ";
        cin >> response;
    }
    while (response[0] == 'Y' || response[0] == 'y');

    return 0;
}
