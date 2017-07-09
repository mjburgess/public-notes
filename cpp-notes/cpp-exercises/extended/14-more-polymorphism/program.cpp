
//======================================================================
//
//  Filename:     program.cpp
//  Description:  Implementation of the programmer class
//
//======================================================================

#include <iostream>                      // Stream class definition
using namespace std;
#include "program.hpp"                   // programmer class definition

//======================================================================
// Prewritten skill functions
//======================================================================

skill::skill(const string & lang, int m)
      : language(lang)
	  , months(m)
{
	// all done
}

skill::~skill()
{
	cout << "skill destructor" << endl;
}


void skill::display() const
{
	cout << language << "  ("  << months << " months experience)" << endl;
}


//======================================================================
// Your programmer functions
//======================================================================

programmer::programmer(const string & n, int a, int g, const money & s)
	: employee(n, a, g, s)
{
   cout << "programmer constructor" << endl;
}
   
   
programmer::~programmer()
{
    cout << "programmer destructor" << endl;
}


void programmer::add_skill(const string & new_language, int months)
{
    skill added(new_language, months);
	skills.push_back(added);
}


void programmer::display() const
{
    employee::display();

    for (size_t i = 0; i < skills.size(); ++i)
    {
        skills[i].display();
    }
}
