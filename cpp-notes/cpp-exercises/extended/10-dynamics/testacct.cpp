
// Chapter:     Dynamic Memory
// File:        testacct.cpp
// Description: Bank account test harness

#include <iostream>
#include <string>
#include <vector>
#include "account.hpp"

using namespace std;

int main()
{
	account myacc("Mr. Smith");
    bool running = true;

    while (running)
    {
        // query option
        cout << "Please enter option (deposit, withdraw, display, exit): ";
        string response;
        cin >> response;

        if (response == "deposit") 
        {
            double amt;
			
			cout << "Please enter amount to deposit: ";
			cin  >> amt;
			myacc.deposit(amt);
		}
        else if (response == "withdraw") 
        {
            double amt;
			
			cout << "Please enter amount to withdraw: ";
			cin  >> amt;

			myacc.withdraw(amt);
		}
        else if (response == "display") 
        {
			myacc.display();
		}
        else if (response == "exit")
        {
            running = false;
        }
    }

    return 0;
}
