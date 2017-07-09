
// Chapter:     Dynamic Memory
// File:        account.cpp
// Description: Class implementation for account class

#include <iostream>
using namespace std;
#include "account.hpp"

account::account(const string & n) 
	: name(n)
	, balance(0.0)
{
	// all done
}


account::~account()
{
	cout << "The destructor is being called" << endl;
	display();

	size_t i;
	for (i = 0; i < deposits_list.size(); i++)
	{
		transaction * pt = deposits_list[i];
		delete pt;
	}

	for (i = 0; i < withdrawals_list.size(); i++)
    {
		transaction * pt = withdrawals_list[i];
		delete pt;
	}
}


void account::deposit(double amt)
{
	balance += amt;

	transaction * ptrans = new transaction(amt);
	deposits_list.push_back(ptrans);
}


void account::withdraw(double amt)
{
	balance -= amt;

	transaction * ptrans = new transaction(amt);
	withdrawals_list.push_back(ptrans);
}


void account::display () const
{
    cout << "Name:    " << name    << endl
	     << "Balance: " << balance << endl;

	cout << "Number of deposits:    " << deposits_list.size()    << endl
	     << "Number of withdrawals: " << withdrawals_list.size() << endl;

	size_t i;
	cout << endl << "Deposits list:" << endl;
	for (i = 0; i < deposits_list.size(); i++)
	{
		cout << deposits_list[i] -> get_info();
	}

	cout << endl << "Withdrawals list:" << endl;
	for (i = 0; i < withdrawals_list.size(); i++)
	{
		cout << withdrawals_list[i] -> get_info();
	}
}
