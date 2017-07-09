
//======================================================================
//
//  Filename:     datetst2.cpp
//  Description:  Simple test harness to exercise the date class.
//
//======================================================================

#include <iostream>
using namespace std;
#include "date.hpp"                // date class definition

int main()
{
	date today(1,1,1960);       // A default date
	cout << "Please type in today's date, DD [space] MM [space] YYYY" << endl; 
	cin >> today;
	date christmas(25, 12, 2012); // Christmas Day

	do                            // Increment "today" until Christmas Day
	{
		today++;
		cout << today << endl;
	}
	while (today != christmas);

	if (today == christmas)
		cout << "Merry Christmas!\n\n";

	++today;
	cout << "Boxing day is " << today;


	//==================================================================
	// Extensions for question 3
	//==================================================================

	date newYearsEve = christmas + 6;
	date newYearsDay = 7 + christmas;

	cout << "\nNew Year's Eve is " << newYearsEve;
	cout << "\nNew Year's Day is " << newYearsDay;
	cout << endl;

    return 0;
}
