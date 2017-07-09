#include <iostream>
using namespace std;

// DESIGN
// composition, aggregation, etc.

//composition:  whole-part (a table is composed of a top & four legs); sine qua non
//association: 

//composition implies -> objects as members , .. v.s,
//association implies -> references/pointers to objects as members

//CONSIDERATIONS 
class Location { public: string city; /* ...and so on */ };
class Instructor { public: string name; /* ...and so on */ };

class Course {
    public:
        Course(string t, Location l, Instructor i): title(t), location(l), instructor(i) { }
    
    public:                                 //for ease 
        string title;
        Location location;
        Instructor instructor;
};

// how do we create Course objects?
// pay special attention to what must be true of t, l and i 

Course cpp() {
    Location uk { "London" };
    Instructor me { "Michael" };

    return Course { "C++", uk, me};
}

int main(void) {
    Course c = cpp();
    cout << c.instructor.name << endl;
    cout << c.title << endl;
    cout << c.location.city << endl;
    return 0; 
}


/* OUTPUT (notes/25.class-composition.cpp):
TODO

*/