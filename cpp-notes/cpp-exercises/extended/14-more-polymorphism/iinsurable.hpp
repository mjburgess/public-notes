//======================================================================
//
//  Filename:     iinsurable.hpp
//  Description:  Definition of a iinsurable interface
//
//======================================================================

#ifndef IINSURABLE_INCLUDED
#define IINSURABLE_INCLUDED

#include <string>
using namespace std;

class iinsurable
{
public:
	virtual void set_policyInfo(double fee, string expiredate, string title) = 0;
	virtual string get_policyInfo() const = 0 ;
	virtual double get_fee() const = 0;

// No data

};

#endif