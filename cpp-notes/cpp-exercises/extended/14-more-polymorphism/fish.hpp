//======================================================================
//
//  Filename:     fish.hpp
//  Description:  Definition of a fish class
//
//======================================================================

#ifndef FISH_INCLUDED
#define FISH_INCLUDED

#include <string>
using namespace std;
#include "iinsurable.hpp"

class fish : public iinsurable
{
public:
	fish(string name, string type):name(name), category(category){}

	virtual void set_policyInfo(double fee, string expiredate, string title);
	virtual string get_policyInfo() const ;
	virtual double get_fee() const;

private:
	string name;
	string category;

	// For iinsurability
	double annualSub;
	string type;
	string end_date;

};

// fish inline functions
inline void fish::set_policyInfo(double fee, string expiredate, string title)
{
	this->annualSub = fee;
	this->type = title;
	this->end_date = expiredate;
}
	
inline string fish::get_policyInfo() const
{
	return type + " expires on " + end_date;
}

inline double fish::get_fee() const
{
	return annualSub;
}

#endif