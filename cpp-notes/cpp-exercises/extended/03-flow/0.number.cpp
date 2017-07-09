
// Chapter:     Control Flow
// File:        number.cpp
// Description: Display a sequence of numbers

#include <iostream>
using namespace std;

int main()
{
    // query range parameters
    cout << "Please enter the lower and upper limits: ";
    int lower, upper;
    cin >> lower >> upper;

    cout << "Please enter the step size: ";
    int step;
    cin >> step;

    // display range
    for (int current = lower; current <= upper; current += step)
    {
        cout << current << endl;
    }

    return 0;
}
