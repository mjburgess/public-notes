#include <iostream>
#include "LibA.hpp"

using namespace std;

//here "extern" means the value of these variables will be provided by another module 
//(translation unit, i.e., compiled .cpp file)
extern string project_name;
extern double project_version;

int main(int argc, char **args) {
    cout << "Welcome to... " << project_name << " v. " << project_version << endl;

    Person me;

    person_init(me, "Michael", 27);
    person_print(me);
}

// COMPILING

// first compile LibA.cpp into LibA.o:   g++ -c LibA.cpp
// then compiled Main.cpp:   g++ Main.cpp 

// or just,   g++ Main.cpp LibA.cpp

// separate compilation highlights how distinct the LibA and Main modules are 


/* OUTPUT (samples/procedural/Main.cpp):
Welcome to... Sample Project v. 1.1
Michael is 27

*/