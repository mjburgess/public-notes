
// Chapter:     Dynamic Memory
// File:        account.hpp
// Description: Class definition for account class

#ifndef ACCOUNT_INCLUDED
#define ACCOUNT_INCLUDED

#include <string>
#include <vector>
#include "transact.hpp"

using namespace std;


// definition of account class

class account
{
public:

    account(const string & n);  // constructor
    ~account();					// destructor
    
	void deposit(double amt);	
	void withdraw(double amt);
	void display () const;

private: // state

    string name;
	double balance;

	vector<transaction *> withdrawals_list;
	vector<transaction *> deposits_list;
};

#endif
