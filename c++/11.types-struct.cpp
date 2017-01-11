#include <iostream>
#include <string>

using namespace std;       

struct date {       //compound type == (int, int int) == {(0,0,0), (0,0,1), (0,0,2), ...} == a very large type!
    int day;        // if i give you a value of type date, I have given you three integers
    int month;
    int year;
};                  //SEMI-COLON!

struct person {
    string name;
    date dob;
};                  //SEMI-COLON!

int main(void) { 
    
    date  firstDayOfMil  = {1, 1, 2000};
    date  secondDayOfMil = {2, 1, 2000};

    const date millenium(firstDayOfMil); //copy constructor -- builds millenium by copying firstDayOfMil

    // millenium = secondDayOfMil; //ERROR -- millenium is const

    cout << "The first day of this millenium occured on " << millenium.day << "." << millenium.month << "." << millenium.year << endl;


    //Q. whats the difference between int[3] and date ?
    int _date[3] = {1, 1, 2000};

    //A struct is *not* to be read as a sequence or collection of its fields
    //an array represents a collection of distinct values, where as a struct represents a single value

    // a date has three components (day, month, year) to be valid

    // structs provide a means to describe a single object where each field represents an independent property of that single object

    //for example,

    person me {"Michael", {30, 05, 1989}};
    cout << "my name is " << me.name << " my birthday is in the " << me.dob.month << "th month" << endl;

    //here the identifier 'me' refers to a single object, a struct, which has various components
    // me has a name, and a dob:  a person's name and a person's dob are properties or aspects of that person 

    //as with vector, we can read me.name asking me for its name


    //NB. each field can be initalized explicitly
    person you;

    you.name = "Sherlock Holmes";
    you.dob.day = 1;
    you.dob.month = 1;
    you.dob.year = 1830;

}


/* OUTPUT (notes/11.types-struct.cpp):
The first day of this millenium occured on 1.1.2000
my name is Michael my birthday is in the 5th month

*/