
// Chapter:     Implementing Classes
// File:        date.hpp
// Description: Class definition for date handling

#ifndef DATE_INCLUDED
#define DATE_INCLUDED

#include <string>

using namespace std;

class date
{
public: // constructors

    date();
    date(int day, int month, int year);

public: // queries

    int  day_in_month() const;
    int  day_in_year() const;
    int  month() const;
    int  year() const;
    bool in_leap_year() const;

public: // modifiers

    void set(int day, int month, int year);
    void reset();

public: // i/o

    void read();
    void write() const;

private: // helper

    bool valid() const;

private: // state

    int dd, mm, ccyy;

};

#endif
