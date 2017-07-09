
// Chapter:     Fundamental Types
// File:        tax.cpp
// Description: Calculate tax to be paid on an item

#include <iostream>
using namespace std;

int main()
{
    // query tax rate
    cout << "Please enter tax rate (%): ";
    double percent;
    cin >> percent;
    const double tax_rate = percent / 100;

    // query amount
    cout << "Please enter amount before tax: ";
    double amount;
    cin >> amount;

    // present results
    double tax = amount * tax_rate;
    cout << "Tax on " << amount << " is " << tax
         << " giving a total of " << amount + tax << endl;

    return 0;
}
