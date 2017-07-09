// Chapter:     Containers
// File:        account.cpp
// Description: Class implementation for account class

#include <iostream>
using namespace std;
#include "account.hpp"

account::account(const string & n) : name(n), balance(0.0)
{
}

account::~account()
{
	cout << "The destructor is being called" << endl;
	display();

	for (size_t i = 0; i != deposits_list.size(); ++i)
	{
		transaction * pt = deposits_list[i];
		delete pt;
	}

	for (size_t k = 0; k != withdrawals_list.size(); ++k)
    {
		transaction * pt = withdrawals_list[k];
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

	cout << endl << "Deposits list:" << endl;
	for (size_t i = 0; i != deposits_list.size(); ++i)
	{
		cout << deposits_list[i] -> get_info();
	}

	cout << endl << "Withdrawals list:" << endl;
	for (size_t k = 0; k != withdrawals_list.size(); ++k)
	{
		cout << withdrawals_list[k] -> get_info();
	}
}

string account::get_name() const
{
	return name;
}
