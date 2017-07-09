
// Chapter:     Control Flow
// File:        dayinyr.cpp
// Description: Find the day in the year from the date

#include <iostream>
#include <string>

using namespace std;

struct date
{
    int day, month, year;
};

int main()
{
    // two lookup tables for the accumulated days
    const int non_leap_total[12] =
    {
        0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334
    };
    const int leap_total[12] =
    {
        0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335
    };

    // lookup table for month names
    const string month_name[] =
    {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    string response;

    do
    {
        date when;
        when.month = 0;

        // query date
        do
        {
            cout << "Please enter a date (dd month yyyy): ";
            string month;
            cin >> when.day >> month >> when.year;

            for (int index = 0; when.month == 0 && index < 12; ++index)
            {
                if (month_name[index] == month)
                {
                    when.month = index + 1;
                }
            }
        }
        while (when.month == 0);

        int day_in_year;

        // calculate results
        if (when.year % 4 == 0 && (when.year % 400 == 0 || when.year % 100 != 0))
        {
            day_in_year = leap_total[when.month - 1] + when.day;
        }
        else
        {
            day_in_year = non_leap_total[when.month - 1] + when.day;
        }

        // present results
        cout << "Day " << day_in_year << endl;

        // query for continuation
        cout << "Do you wish to enter another date [Yes | No]? ";
        cin >> response;
    }
    while (response[0] == 'Y' || response[0] == 'y');

    return 0;
}
