// Chapter:     Containers
// File:        account.hpp
// Description: Class definition for account class

#ifndef ACCOUNT_INCLUDED
#define ACCOUNT_INCLUDED

#include <vector>
#include "transact.hpp"


// definition of account class

class account
{
public:

    account(const string & n);  // constructor
    ~account();					// destructor
    
	void deposit(double amt);	
	void withdraw(double amt);
	void display () const;
    string get_name() const;

private: // private data

    string name;
	double balance;

	vector<transaction *> withdrawals_list;
	vector<transaction *> deposits_list;
};

#endif
