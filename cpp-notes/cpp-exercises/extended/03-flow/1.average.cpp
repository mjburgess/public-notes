
// Chapter:     Control Flow
// File:        average.cpp
// Description: Calculate the averages of a sequence of numbers

#include <cmath>
#include <iostream>
#include <string>

using namespace std;

int main()
{
    string response;

    do
    {
        // initialise data set details
        cout << "How many numbers do you wish to enter? ";
        int size;
        cin >> size;
        double total   = 0;
        double squares = 0;
        double product = 1;

        // query each item in data set
        for (int position = 0; position < size; ++position)
        {
            cout << "[" << position << "] = ";
            int item;
            cin >> item;

            total   += item;
            squares += item * item;
            product *= item;
        }

        // calculate and present results
        if (size > 0)
        {
            double arithmetic_mean    = total / size;
            double variance           = (squares / size) - arithmetic_mean*arithmetic_mean;
            double standard_deviation = sqrt(variance);
            double geometric_mean     = pow(product, 1.0 / size);

            cout << "The arithmetic mean is "    << arithmetic_mean    << endl
                 << "The variance is "           << variance           << endl
                 << "The standard deviation is " << standard_deviation << endl
                 << "The geometric mean is "     << geometric_mean     << endl;
        }

        // query for continuation
        cout << "Do you wish to enter another data set [Yes | No]? ";
        cin >> response;
    }
    while (response[0] == 'Y' || response[0] == 'y');

    return 0;
}
