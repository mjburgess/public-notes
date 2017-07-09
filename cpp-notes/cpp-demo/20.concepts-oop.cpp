#include <iostream>
using namespace std;

//1. oo = STATE and BEHAVIOUR are TOGETHER

//object oriented programs group data and behaviour together
//data is active: people objects are asked for their details

// data in this case is "an object" -- a particular conrete bit of stuff 
// which has two aspects: it has its state == its facts  == its concrete properties (eg. its weight)
// and it has its behaviour                == the operations which concern its state (eg. eating)

// to make objects we first need specifications which determine how they are made
// the specification will provide the operations, stated generally, that apply to all examples of that type of object
// and it will provide an outline of what the various kinds of properties an object will have

// for example, the specification will say: "all electrical-toys have a colour (state) and can be switched-on"
// it will not say what the colour is: a particular toy object has the particular colour



//2. DESIGN
//What are the properties (english-meaning) of a person?
//let's say name/height/weight

//What can a person do?
//let's say eat

// ignore the fine details of the syntax for now:

class Person {      // here we are defining a specification from which we can create particular people
    public:         // ignore this for now  

    // here we say every Person has a name, height and weight
    string name;
    double height;
    double weight;
    

    // here we say every person can eat
    double eat(double amount) {
        return this->weight += amount; // when a particular person eats it updates *its* weight
                                      // you can read "this->weight" as saying the weight of the object-in-question
    }                                 // -- as this is just a blueprint, we havent created any object yet



    // each of these functions just provides information about the object
    // const after the name is a promise that the function will not moidfy the object-in-question
    double bmi() const {
        return this->weight / (this->height * this->height);
    }
    
    void print() const {
        cout << this->name << " is " << this->height << " m and " << this->weight << " kg; BMI=" << this->bmi() << endl;
    }
};      //SEMI-COLON!

int main(void) {
    Person mycroft  { "Mycroft Holmes", 1.85, 70 };     //create two objects
    Person sherlock { "Sherlock Holmes", 1.80, 72 };

    mycroft.eat(0.5);       //mycroft eats
    sherlock.eat(0.2);      //sherlock eats

    mycroft.print();        
    sherlock.print();

    // compare this to the procedural phrasing:    person_eat(mycroft)

    cout << boolalpha;

    // 3. IDENTITY
    Person another_sherlock { "Sherlock Holmes", 1.80, 72};

    //notice that another_sherlock and sherlock have all the same values for their properties
    // yet, they are not identical!

    cout << "another sherlock is sherlock ? " << (&another_sherlock == &sherlock) << endl;

    // these two objects are distinct even when all of their properties are the same..

    // though really, there is in fact a hidden property which differs: their memory location
    // if this were the same then they would be identical:

    Person *maybe_sherlock = &sherlock;

    cout << "maybe sherlock is sherlock ? " << (maybe_sherlock == &sherlock) << endl;

    //(... Leibniz's law of identity requires 
    //that there must be at least one property which differes if two objects are distinct ...)
 }


/* OUTPUT (notes/20.concepts-oop.cpp):
Mycroft Holmes is 1.85 m and 70.5 kg; BMI=20.599
Sherlock Holmes is 1.8 m and 72.2 kg; BMI=22.284
another sherlock is sherlock ? false
maybe sherlock is sherlock ? true

*/