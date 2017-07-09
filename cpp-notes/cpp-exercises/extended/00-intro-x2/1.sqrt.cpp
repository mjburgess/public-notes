#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    cout << "Please enter a number: ";
    double input;
    cin >> input;

    //Q. if the number was negative, message the user rejecting it 

    cout << "Root is " << sqrt(abs(input)) << endl;

    //Q. tell the user what their number squared is
     
    return 0;
}
