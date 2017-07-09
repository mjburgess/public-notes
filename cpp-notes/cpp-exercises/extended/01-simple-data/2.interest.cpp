
// Chapter:     Fundamental Types
// File:        interest.cpp
// Description: Calculate interest on an amount over time

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    // query interest rate
    cout << "Please enter rate of interest (%): ";
    double percent;
    cin >> percent;
    double interest_rate = 1 + (percent / 100);

    // query investment amount
    cout << "Please enter amount to invest: ";
    double amount;
    cin >> amount;

    // query investment period
    cout << "Please enter investment period (years months): ";
    int years, months;
    cin >> years >> months;
    double period = years + months / 12.0;

    // calculate and present results
    double accumulated_rate = pow(interest_rate, period);
    cout << "Total will be " << amount * accumulated_rate << endl;

    return 0;
}
