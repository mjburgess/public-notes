#include <iostream>

using namespace std;

int main(void) {       

    //BOOLEANS

    // two views of types: "memory modes", "set of values which share the same property"
    // the type bool == {true, false}
    // the type int  == {-2.1 billion, ... 0, 1, 2, ... 2.1 billion } 

    bool isAdult = true;
    bool isClosed  = false;
    bool isAllowedIn = isAdult && !isClosed;

    bool isOpen = 1;
    int isFarAway = false;      //alas, valid! -- hence set-view of types not enough
    int isTall = 0;             // 0 == false,  non-0 == true

    cout << boolalpha; //another stream modifier Q. what happens if you comment out?
                       //NB. I often use boolapha in these notes before cout'ing a bool  

    cout << "are you an adult? " << isAdult << endl;
    cout << "is the bar closed? " << isClosed << endl;
    cout << "can you go in? " << isAllowedIn << endl;
    cout << "is it open? " << isOpen << endl;
    cout << "is it far away? " << isFarAway << endl;

    cout << (!isFarAway && !isClosed ? "I'm going! " : "I'm not going! '") << endl; 
    cout << (isAdult || isTall  ? "I can ride!" : "I'm not allowed to ride!") << endl; 
    cout << (isAdult && isTall  ? "I can ride!" :  "I need to be a tall adult!") << endl; 


    // lvalue usage (gasp!)

    int people = 10;
    int dogs = 10;

    bool isBusOfDogs = true;

    (isBusOfDogs ? dogs : people) += 10;    //add 10 to dogs

    cout << "dogs " << dogs << " people " << people << endl;


    // to illustrate the use of comparison operators which evaluate to true/false
    if(people > dogs) {
        cout << "there are more people than dogs" << endl;
    } else if(people != dogs) {
        cout << "there are a different number of people and dogs" << endl;
    } else if (people == dogs) {
        cout << "there are the same number of people and dogs" << endl;
    } else {
        cout << " will this ever be run? " << endl;
    }
}


/* OUTPUT (notes/04.types-bools.cpp):
are you an adult? true
is the bar closed? false
can you go in? true
is it open? true
is it far away? 0
I'm going! 
I can ride!
I need to be a tall adult!
dogs 20 people 10
there are a different number of people and dogs

*/