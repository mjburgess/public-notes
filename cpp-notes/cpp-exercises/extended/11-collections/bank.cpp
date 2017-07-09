// Chapter:     Containers
// File:        bank.cpp
// Description: Class implementation for bank class

#include <iostream>
using namespace std;
#include "bank.hpp"

bank::bank(const string & n, const string & sc)
     :name_of_bank(n),
      sort_code(sc)
{}

/*
bank::~bank()
{
	cout << "In the bank destructor, deleting accounts" << endl;

	list<account *>::iterator iter;

	for (iter = thelist.begin(); iter != thelist.end(); ++iter)
	{
		account * pacct = *iter;
		delete pacct;
	}
}
*/

/*
alternative version of the destructor
using auto in a for loop
*/
bank::~bank()
{
	cout << "In the bank destructor, deleting accounts" << endl;

	for (auto iter = thelist.begin(); iter != thelist.end(); ++iter)
	{
		account * pacct = *iter;
		delete pacct;
	}
}


void bank::add_account()
{
	string name;
	cout << "Name of account holder: ";
	cin  >> name;
	
	account * p = new account(name);
	thelist.push_back(p);
}

/*
void bank::display_list() const
{
	cout << "Bank name: " << name_of_bank << endl;
	cout << "Sort code: " << sort_code << endl;

	list<account *>::const_iterator iter;

	for (iter = thelist.begin(); iter != thelist.end(); ++iter)
	{
		account * pacct = *iter;
		pacct->display();
	}
}
*/

/*
alternative version of display_list
using a range for loop
*/

void bank::display_list() const
{
	cout << "Bank name: " << name_of_bank << endl;
	cout << "Sort code: " << sort_code << endl;

	
	for (const account * acc :thelist)
	{		
		acc->display();
	}
}

/*
void bank::remove_account()
{
	string name;
	cout << "Name of the account to be deleted: ";
	cin >> name;
	
	// cannot be const_iterator this time
	list<account *>::iterator iter = thelist.begin(); 
	
	while (iter != thelist.end() && (*iter)->get_name() != name)
	{
		++iter;
	}

	if (iter != thelist.end())
	{
		// name was found
		account * pacct = *iter;
		delete pacct;
		thelist.erase(iter);
	}
	else
	{
		// name wasn't found
		cout << "Name not recognised" << endl;
	}
}

*/ 
 
/* 
 alternative version of remove_account
 using auto in a for loop
*/

void bank::remove_account()
{
	string name;
	cout << "Name of the account to be deleted: ";
	cin >> name;
	
	
	for (auto iter = thelist.begin(); iter != thelist.end(); ++iter)
	{
		account * pacct = *iter;
		if (pacct->get_name() == name)
		{
			delete pacct;
			thelist.erase(iter);
			//
			// NOTE
			// you must return here, otherwise the ++iter
			// will be invoked which will have undefined behaviour
			// because you've just erased iter!!

			return;
		}
	}

	// If we get this far, we didn't find the name we were looking for
	cout << "Name not recognised" << endl;
}

