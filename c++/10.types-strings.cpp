#include <iostream>
#include <string>       // REQUIRED for string

using namespace std;       

int main(void) { 
    char first_name[] = {'M', 'i', 'c', 'h', 'a', 'e', 'l', '\0'};
    char last_name[] = "Burgess";

    const char *title = "Mr. ";   

    cout << title << first_name << " " << last_name << endl;        //cout works with C++ strings
                                                                    //each of the above is convertable to C++ strings
    //DOWNSIDES:
    // character arrays cannot be easily concatentated, moved around, compared
    // all of these operations require c std lib functions (strcat, strcmp, etc.)

    //C++ strings

    string name = "Michael";
    name = "Mr. " + name + " Burgess";          // + operator is polymorphic, defined on strings as concatenation

    name[0] = name[4] = 'm';
    name[12] = 'b';
    cout << name << endl;


    //LOOKUP TABLE

    const string messages[] = {"Good Morning", "Good Evening", "Good Night"};
    enum daytime {
        Morning, Afternoon, Evening
    };

    cout << messages[Morning] << endl;      //simulates an associative array, where the keys are named rather than numeric
}


/* OUTPUT (notes/10.types-strings.cpp):
Mr. Michael Burgess
mr. michael burgess
Good Morning

*/