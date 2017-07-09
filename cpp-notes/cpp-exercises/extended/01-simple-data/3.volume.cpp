
// Chapter:     Fundamental Types
// File:        volume.cpp
// Description: Calculate the volume and surface area of a sphere

#include <iostream>
#include <cmath>
using namespace std;
#pragma warning(disable: 4056)
#pragma warning(disable: 4146)

int main()
{
    // calculate constant
    const double pi = atan2(0.0, -1.0);

    // query radius value
    cout << "Please enter sphere radius: ";
    double radius;
    cin >> radius;

    // calculate and present results
    double volume = (4.0 / 3.0) * pi * (radius * radius * radius);
    double area = 4 * pi * (radius * radius);
    cout << "The volume of the shere is " << volume
         << " and its surface area is " << area << endl;

    return 0;
}
