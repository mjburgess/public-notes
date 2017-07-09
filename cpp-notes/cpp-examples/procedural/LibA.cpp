#include <iostream>
#include <string>
#include "LibA.hpp"

using namespace std;

// in the global scope, static means "hide from other modules (translation units, ie. compiled .cpp files)"

string project_name = "Sample Project";
double project_version = 1.1;
static int project_password = 1234;         //not available to other modules


void person_init(Person &p, string name, int age) {
    p.name = name;
    p.age = age;
}

void person_print(Person &p) {
    cout << p.name << " is " << p.age << endl;
}

