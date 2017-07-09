
// Chapter:     Functions
// File:        date.cpp
// Description: Date type and date handling prototypes

#include <iostream>
#include <string>
using namespace std;
#include "date.hpp"


bool is_leap_year(int year)
{
    return year % 4 == 0 && (year % 400 == 0 || year % 100 != 0);
}

bool is_valid(const date & when)
{
    static const int non_leap_days[12] =
    {
        31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    };
    static const int leap_days[12] =
    {
        31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    };

    bool result = false; // pessimistic

    if (when.day > 0 && when.month >= 1 && when.month <= 12)
    {
        if (is_leap_year(when.year))
        {
            result = when.day <= leap_days[when.month - 1];
        }
        else
        {
            result = when.day <= non_leap_days[when.month - 1];
        }
    }

    return result;
}

int day_in_year(const date & when)
{
    // two lookup tables for the accumulated days
    static const int non_leap_total[12] =
    {
        0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334
    };
    static const int leap_total[12] =
    {
        0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335
    };

    int result;

    if (is_leap_year(when.year))
    {
        result = leap_total[when.month - 1] + when.day;
    }
    else
    {
        result = non_leap_total[when.month - 1] + when.day;
    }

    return result;
}

int day_in_week(const date & when)
{
    // use variable names from algorithm spec
    int d = when.day, m = when.month, y = when.year, z;
    
    if (m == 1 || m == 2)
    {
        d -= is_leap_year(y) ? 2 : 1;
        m += 12;
    }

    z = (1 + d + (m * 2) + (3 * (m + 1) / 5) + y + y/4 - y/100 + y/400) % 7;

    return z;
}

bool read(date & when)
{
    bool result = true; // optimistic

    date input;
    cin >> input.day >> input.month >> input.year;

    if (is_valid(input))
    {
        when = input;
    }
    else
    {
        result = false;
    }

    return result;
}

void write(const date & when, date_format format)
{
    static const string day_name[] =
    {
        "Sunday", "Monday", "Tuesday", "Wednesday",
        "Thursday", "Friday", "Saturday"
    };
    static const string month_name[] =
    {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    switch (format)
    {
    case ddmmyyyy:
        cout << when.day << '/' << when.month << '/' << when.year;
        break;
    case dddyyyy:
        cout << day_in_year(when) << '/' << when.year;
        break;
    case verbose:
        cout << day_name[day_in_week(when)] << ' '
             << when.day << ' '
             << month_name[when.month - 1] << ' '
             << when.year;
        break;
    }
}
