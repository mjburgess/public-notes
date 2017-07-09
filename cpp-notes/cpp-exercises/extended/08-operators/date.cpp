
//======================================================================
//
//  Filename:     date.cpp
//  Description:  Implementation of the date class
//
//======================================================================

#include <iostream>             // Stream classes
using namespace std;
#include <cstdio>               // sprintf() prototype
#include "date.hpp"             // date class

//====================================================================== 
// Equality and inequality operators (question 1)
//======================================================================

bool operator==(const date & lhs, const date & rhs)
{
    return lhs.compare(rhs) == 0;
}


bool operator!=(const date & lhs, const date & rhs)
{
    return lhs.compare(rhs) != 0;
}

//====================================================================== 
// Prefix and postfix ++ operators (question 2)
//======================================================================

date & date::operator++ ()      // Prefix increment
{
    next_day();                 // Increment the date
    return *this;               // Return new date
}


date date::operator++(int)      // Postfix increment
{
    date old_self = *this;      // Take a snapshot of current date
    ++(*this);                  // Increment current date
    return old_self;            // Return the original date
}


//====================================================================== 
// Operator + functions (question 3)
//======================================================================

date operator+(const date & lhs, int num_days)
{
    date result = lhs;
    
    while (num_days-- != 0)      // There are more efficient algorithms
        result.next_day();       // than this!!
    
    return result;
}


date operator+(int num_days, const date & rhs)
{
    return rhs + num_days;   // Simply latch onto the function above 
}

// Global I/O operators
ostream & operator << (ostream & out, const date & rhs)
{
	out << rhs.format();
	return out;

}

istream & operator >> (istream & in, date & rhs)
{
	in >> rhs.getDay()  >> rhs.getMonth() >> rhs.getYear();
	return in;

}

//========================================================================
// Pre-written functions ...
//========================================================================

date::date(int d, int m, int y) 
	: day(d), month(m), year(y)
{
	// all done
}


void date::next_day()
{
    if (++day > days_in_month())
    {
        day = 1;
        if (++month > 12)
        {
            month = 1;
            year++;
        }
    }
}


bool date::is_leap() const
{
    return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
}


int date::days_in_month() const
{
    static const int numdays[] = {31,28,31,30,31,30,31,31,30,31,30,31};

    if (month == 2 && is_leap())
        return 29;
    else
        return numdays[month - 1];
}


int date::compare(const date & rhs) const
{
	int result;
	
	if (year < rhs.year)
		result = -1;
	else if (year > rhs.year)
		result = +1;
	else if (month < rhs.month)
		result = -1;
	else if (month > rhs.month)
		result = +1;
	else if (day < rhs.day)
		result = -1;
	else if (day > rhs.day)
		result = +1;
	else
		result = 0;

	return result;
}


string date::format() const
{               
    char temp_buf[10+1];
    sprintf(temp_buf, "%02d/%02d/%02d", day, month, year);
    return string(temp_buf);
}
