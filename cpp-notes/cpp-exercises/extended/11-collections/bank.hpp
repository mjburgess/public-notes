// Chapter:     Containers
// File:        bank.hpp
// Description: Class definition for bank class

#ifndef BANK_INCLUDED
#define BANK_INCLUDED

#include <list>
#include <string>
#include "account.hpp"

using namespace std;

class bank
{
public:
	bank(const string & n, const string & sc);
	~bank();

	void add_account();
	void display_list() const;
	void remove_account();

private:
	string name_of_bank;		// Eg "Barclays"
	string sort_code;			// Eg "20-05-02"

	list<account *> thelist;
};

#endif