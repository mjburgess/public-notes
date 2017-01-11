#include <iostream>
#include <string>
using namespace std;

class Person_ {
    public:
        string getName() { return name; }
        int getAge() { return age; }
    private:
        string name;
        int age;
};  //SEMI-COLON!


Person_ sherlock;
//Q. what is the initial state of sherlock?
//ie., what is its name, its age?

//A. undefined..

//as a general principle it should never be possible to have hold of an object that is in an inconsistent state
//eg. a bank account that has an unallowed negative balance; a door which is both open and closed;
//a person with an undefined name, and an undefined age

//objects in inconsistent states do not follow the patterns we set out for them in their methods:
//their state change can be unpredictable and difficult to reason about. 

//to ensure objects are always initialize to a sensible default, C++ provide constructor methods

// constructors are methods which construct, or build, the object 
// they are called automatically whenever an object is created
// they have the same name as the class and no return type

class Person {
    public:
        Person(string name,  int age);
        string getName() { return name; }
        int getAge()  { return age; }
    private:
        string name;
        int age;
};  //SEMI-COLON!

/* EXTENDED FORM: 

Person::Person(string name, int age) {
    this->name = name;
    this->age = age;
}

*/

//abbreviated form
Person::Person(string n, int a) : name(n), age(a) { 
    cout << "creating " << n << endl;                   //often these are empty
}                                                       //ie. the constructor merely initializes private state

// the "member constructors" (eg. name(n), age(a)) are executed in order 

int main(void) {

    // there are various ways we can create an object, 
    //in each case the constructor is called
    Person me { "Michael Burgess", 27 };                        //1. C++11 "uniform syntax"
    Person watson("Dr. Watson", 35);                            //2. 
    Person sherlock = {"Sherlock Holmes", 27};                  //3. 

    //for consistency, in these notes, I use the uniform syntax
    //but the parenthetical syntax (2.) is perhaps most common
    // the parentheses on (2.) can be read as aligning with those of the constructor..
    //ie., we could read watson(x,y) as Watson::Watson(x, y)

    cout << me.getName() << " is " << me.getAge() << endl;
    cout << watson.getName() << " is " << watson.getAge() << endl;
    cout << sherlock.getName() << " is " << sherlock.getAge() << endl;
    
    return 0; 

}


/* OUTPUT (notes/23.class-constructors.cpp):
TODO

*/