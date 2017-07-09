
//======================================================================
//
//  Filename:     date.hpp
//  Description:  Definition of the date class
//
//======================================================================

#ifndef DATE_INCLUDED
#define DATE_INCLUDED

#include <string>                            // #include for string class

using namespace std;

class date
{
public: // behaviour

    date(int d, int m, int y);                // Constructor
    void next_day();                          // Increment to next day
	int compare(const date & rhs) const;      // Compare two dates, returns <0,0,>0
	string format() const;                    // Return the date (dd/mm/yyyy) 

public: // inline Accessors!
	int & getDay()  {return day;}
	int & getMonth()  {return month;}
	int & getYear()  {return year;}

public: // increment

    date & operator++();                     // Pre-increment
    date operator++(int);                    // Post-increment

private: // helpers

    bool is_leap() const;                     // Check if leap year
    int  days_in_month() const;               // Get number of days in month


private: // representation

    int  day, month, year;                    // Instance data
};

// Global relational operators
bool operator==(const date & lhs, const date & rhs);
bool operator!=(const date & lhs, const date & rhs);

// Symmetric binary + operators
date operator+(const date & lhs, int rhs);
date operator+(int lhs, const date & rhs);

//Global I/O operators
ostream & operator << (ostream & out, const date & rhs);
istream & operator >> (istream & out, date & rhs);
#endif
