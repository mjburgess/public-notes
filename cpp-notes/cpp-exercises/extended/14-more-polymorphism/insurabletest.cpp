
//======================================================================
//
//  Filename:     insurabletest.cpp
//  Description:  Test harness to exercise the iinsurable interface
//
//======================================================================

#include <iostream>                      // Stream class definition
using namespace std;
#include "program.hpp"                   // programmer class definition

int main()
{
    
    employee emp("Bloggs", 35, 9, 15000);   // Create an employee object
    
    emp.gain_promotion(3);

	emp.set_policyInfo(100.00, "2013-10-10", "Professional Indemnity");
    emp.display();
    
    cout << "Years to retirement: " << emp.years_to_retirement() << endl;

	programmer me("Gill Bates", 40, 15, 25000);
    
    me.add_skill("C++", 12);
    me.add_skill("Visual Basic", 6);
    me.gain_promotion(3);
	me.set_policyInfo(75.00, "2015-10-10", "Language skills going out of date");

    cout << "\nDisplaying programmer details\n";
    me.display();

    return 0;
}
