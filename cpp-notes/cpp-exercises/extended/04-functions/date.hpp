
// Chapter:     Functions
// File:        date.hpp
// Description: Date type and date handling prototypes

#ifndef DATE_INCLUDED
#define DATE_INCLUDED

// definition of date type

struct date
{
    int day, month, year;
};

enum date_format { ddmmyyyy, dddyyyy, verbose };

// operations on date type

bool is_leap_year(int yyyy);
bool is_valid(const date &);
int  day_in_year(const date &);
int  day_in_week(const date &);
bool read(date &);
void write(const date &, date_format = ddmmyyyy);

#endif
