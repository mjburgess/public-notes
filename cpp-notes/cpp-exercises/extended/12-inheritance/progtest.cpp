
//======================================================================
//
//  Filename:     progtest.cpp
//  Description:  Test harness to exercise the programmer class
//
//======================================================================

#include <iostream>                      // Stream class definition
using namespace std;
#include "program.hpp"                   // programmer class definition

int main()
{
    programmer progger("Gill Bates", 40, 15, 25000);
    
    progger.add_skill("C++", 12);
    progger.add_skill("Visual Basic", 6);
    progger.gain_promotion(3);

    cout << "\nDisplaying programmer details\n";
    progger.display();

    return 0;
}
