
//======================================================================
//
//  Filename:     program.hpp
//  Description:  Definition of the programmer class
//
//======================================================================

#ifndef PROGRAMMER_INCLUDED
#define PROGRAMMER_INCLUDED

#include <vector>                       // vector class definition
#include "person.hpp"                   // Base-class definitions

using namespace std;

//======================================================================
// Prewritten skill class, which defines info about programming skills
//======================================================================

class skill
{
public:
    
	skill(const string & language, int months);  // Constructor
   ~skill();

    void display() const;               // Display programming skill info

private: // state

    string language;                    // Name of language, eg "C++"
    int    months;                      // Months of programming experience
};


//======================================================================
// Your programmer class
//======================================================================

class programmer : public employee
{
public:

    programmer(const string & name, int age, int grade, const money & salary);
   ~programmer();

    void add_skill(const string & new_language, int months);
    void display() const;

private: // state

    vector<skill> skills;
};

#endif
