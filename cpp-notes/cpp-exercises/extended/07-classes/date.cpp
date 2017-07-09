
// Chapter:     Implementing Classes
// File:        date.cpp
// Description: Member definitions for date class

#include <iostream>
using namespace std;
#include "date.hpp"

date::date()
  : dd(1), mm(1), ccyy(1970)
{
	// all done
}


date::date(int day, int month, int year)
  : dd(day), mm(month), ccyy(year)
{
    if (!valid())
    {
        reset();
    }
}


int date::day_in_month() const
{
    return dd;
}


int date::day_in_year() const
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

    // calculate result
    if (in_leap_year())
    {
        result = leap_total[mm - 1] + dd;
    }
    else
    {
        result = non_leap_total[mm - 1] + dd;
    }

    return result;
}


int date::month() const
{
    return mm;
}


int date::year() const
{
    return ccyy;
}


bool date::in_leap_year() const
{
    return ccyy % 4 == 0 && (ccyy % 400 == 0 || ccyy % 100 != 0);
}


void date::set(int day, int month, int year)
{
    // optimistically set members
    dd   = day;
    mm   = month;
    ccyy = year;

    // rollback
    if (!valid())
    {
        reset();
    }
}


void date::reset()
{
    dd   = 1;
    mm   = 1;
    ccyy = 1970;
}


void date::read()
{
    cin >> dd >> mm >> ccyy;

    if (!valid())
    {
        reset();
    }
}


void date::write() const
{
    cout << dd << '/' << mm << '/' << ccyy;
}


bool date::valid() const
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

    if (dd > 0 && mm >= 1 && mm <= 12)
    {
        if (in_leap_year())
        {
            result = dd <= leap_days[mm - 1];
        }
        else
        {
            result = dd <= non_leap_days[mm - 1];
        }
    }

    return result;
}
