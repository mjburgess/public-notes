
//======================================================================
//
//  Filename:     person.cpp
//  Description:  Implementation of the person hierarchy
//
//======================================================================

#include <iostream>                     // Stream class definition
using namespace std;
#include "person.hpp"                   // person class hierarchy

//======================================================================
// Your person functions
//======================================================================

person::person(const string & n, int a) 
	: name(n)
	, age(a)
{
    cout << "person constructor" << endl;
}

   
person::~person()
{
    cout << "person destructor" << endl;
}

    
void person::display() const
{
    cout << "Name: " << name << endl;
    cout << "Age:  " << age  << endl;
}


int person::get_age() const
{
    return age;
}


//======================================================================
// student functions
//======================================================================

student::student(const string & n, int a, const string & s)
	: person(n, a)
	, subject(s)
{
    cout << "student constructor" << endl;
}
   
   
student::~student()
{
    cout << "student destructor" << endl;
}


void student::change_subject(const string & new_subject)
{
    subject = new_subject;  

    // Note: we could also have written this as follows:
    //    subject.assign(subj);
}


void student::display() const
{
    person::display();       // Display base-class data
    
    cout << "Subject: " << subject << endl;
}


//======================================================================
// employee functions
//======================================================================

employee::employee(const string & n, int a, int g, const money & s)
	: person(n, a)
	, jobgrade(g)
	, salary(s)
{
   cout << "employee constructor" << endl;
}
   
   
employee::~employee()
{
   cout << "employee destructor" << endl;
}


void employee::gain_promotion(int numgrades)
{
    money payrise = rise_per_grade * numgrades;

    salary += payrise;
}


int employee::years_to_retirement() const
{
    return retirement_age - get_age();
}

    
void employee::display() const
{
    person::display();       // Display base-class data
    
    cout << "Grade: " << jobgrade << ", salary ";
    salary.display();

	cout << get_policyInfo() << " costing $" << get_fee() << " per year" << endl;
}

void employee::set_policyInfo(double fee, string expiredate, string title)
{
	this->fee = fee;
	this->title = title;
	this->expiry_date = expiredate;
}
	
string employee::get_policyInfo() const
{
	return title + " expires on " + expiry_date;
}

double employee::get_fee() const
{
	return fee;
}