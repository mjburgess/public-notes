// Chapter:     Containers
// File:        transact.cpp
// Description: Class implementation for transaction class

#include <string>
#include <stdio.h>
#include "transact.hpp"

using namespace std;

transaction::transaction(double amt) : amount_for_this_transaction(amt)
{
}

transaction::~transaction()
{
	cout << "Transaction destructor called for: " 
		 << amount_for_this_transaction
		 << "\n";
}

string transaction::get_info() const
{
	char buf[30];
	sprintf(buf, "Transaction: %0.2f\n",  amount_for_this_transaction);
	return buf;
}
