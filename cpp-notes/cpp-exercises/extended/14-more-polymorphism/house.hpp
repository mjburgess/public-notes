//======================================================================
//
//  Filename:     house.hpp
//  Description:  Definition of a house class
//
//======================================================================

#ifndef HOUSE_INCLUDED
#define HOUSE_INCLUDED

#include <string>
using namespace std;
#include "iinsurable.hpp"

class house : public iinsurable
{
public: // nested types
	enum houseE {semi, terrace, mansion, palace};
	
public:
	house(string address, string postcode, houseE category):address(address), postcode(postcode), category(category){}
	virtual void set_policyInfo(double fee, string expiredate, string title);
	virtual string get_policyInfo() const ;
	virtual double get_fee() const;

private:
	string address;
	string postcode;
	houseE category;

	// For iinsurability
	double insurance_fee;
	string type;
	string policy_date;

};

// house inline functions
inline void house::set_policyInfo(double fee, string expiredate, string title)
{
	this->insurance_fee = fee;
	this->type = title;
	this->policy_date = expiredate;
}
	
inline string house::get_policyInfo() const
{
	return type + " expires on " + policy_date;
}

inline double house::get_fee() const
{
	return insurance_fee;
}

#endif