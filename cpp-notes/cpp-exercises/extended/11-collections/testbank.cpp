
// Chapter:     Container
// File:        testbank.cpp
// Description: Bank account test harness

#include <iostream>
#include <string>
#include <vector>

#include "bank.hpp"
#include "account.hpp"

using namespace std;

int main()
{
	bank mybank("Barclays", "20-05-02");
	
    bool running = true;

    while (running)
    {
        // query option
        cout << "Please enter option (add, remove, display, exit): ";
        string response;
        cin >> response;

        if (response == "add") 
        {
			mybank.add_account();
		}
        else if (response == "remove") 
        {
			mybank.remove_account();
		}
        else if (response == "display") 
        {
			mybank.display_list();
        }
		else if (response == "exit")
        {
            running = false;
        }
    }
    return 0;
}
