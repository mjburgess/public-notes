
// Chapter:     Dynamic Memory
// File:        transact.hpp
// Description: Class definition for transaction class

#ifndef TRANSACTION_INCLUDED
#define TRANSACTION_INCLUDED

#include <string>

using namespace std;

// definition of transaction class

class transaction
{
public:

	transaction(double amt);
	~transaction();

	string get_info() const;

private: // state

    double amount_for_this_transaction;
};

#endif
