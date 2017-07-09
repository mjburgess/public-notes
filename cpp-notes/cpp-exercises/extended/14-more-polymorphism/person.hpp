
//======================================================================
//
//  Filename:     person.hpp
//  Description:  Definition of the person hierarchy
//
//======================================================================

#ifndef PERSON_INCLUDED
#define PERSON_INCLUDED

#include <string>		                      // #include for string class
#include "money.hpp"                          // money class definition
#include "iinsurable.hpp"

using namespace std;

//======================================================================
// Your person base class
//======================================================================

class person
{
public:

   ~person();

   // Only change to switch on polymorphism ...
    virtual void display() const;                     // Display data - now virtual

protected:
	person(const string & name, int age); // Person is now abstract
    int get_age() const;                      // Accessor function

private: // state

    string name;                              // Private data members
    int    age;
};
    
    
//======================================================================
// Your student class
//======================================================================

class student : public person
{
public:

    student(const string & name, int age, const string & subject);
   ~student();

    void change_subject(const string & new_subject); // Additional functions
    void display() const;

private: // state

    string subject;                           // Additional data 
};
    
    
//======================================================================
// Your employee class
//======================================================================

class employee : public person, public iinsurable
{
public:

    employee(const string & name, int age, int grade, const money & salary);
   ~employee();                             

    void gain_promotion(int numgrades);   // Additional functions
    int  years_to_retirement() const;                     
    
    void display() const;    

	// For iinsurable
	void set_policyInfo(double fee, string expiredate, string title);
	string get_policyInfo() const;
	double get_fee() const;


private: // state

    int   jobgrade;                       // Additional data
    money salary;                           
    
    enum { rise_per_grade = 1000 };
    enum { retirement_age = 65   };

	// For iinsurability
	double fee;
	string title;
	string expiry_date;
};

#endif
