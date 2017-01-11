#include <iostream>
#include <string>
using namespace std;

//foundations of procedural programming ii

// 1. procedural = STATE and BEHAVIOUR are SEPARATE

//procedural programming (particular type of imperative) groups data and behaviour separately
//data is "inert" it just sits around and waits for functions to operate on it 
//a person's details are passed to operations in order to achive effects

//data is specific to a particular person
string myName = "Sherlock Holmes";
double myHeight = 1.81;
double myWeight = 70.0;


//functions are generic, applying to all people (ie. name/height/weights)
double person_bmi(double theirHeight, double theirWeight) {
    return theirWeight / (theirHeight * theirHeight);
}

void person_print(string theirName, double theirHeight, double theirWeight) {
    double theirBMI = person_bmi(theirHeight, theirWeight);
    
    cout << theirName << " is " << theirHeight << " m and " << theirWeight << " kg; BMI=" << theirBMI << endl;
}


// functions may be polymorphic (ad hoc polymorphism)
// meaning that the particular operation chosen depends on the type of the arguments of the function
// polymorphism == having many forms . here 'person_print' has many forms. 

void person_print(string theirName) {
    cout << theirName << endl;
}
void person_print(double theirHeight, double theirWeight) {
    person_print("Unknown", theirHeight, theirWeight);    
}

// polymorphism is used to specialize an operation to a particular type 
// there is nothing particular OO about it, though in the context of C++ polymorphism is treated as "something objects do"
// outisde of this strange language however, polymorphism just means type-dependent specialization


// above we should think of "person_print" as a family of operations all united by certain laws,
// ie. patterns that they will follow
// the particular behaviour selected will depend on the type of the arguments

int main(void) {
    person_print(myName, myHeight, myWeight);

    
    person_print(myName);
    person_print(myWeight, myHeight);
    return 0;
}


/* OUTPUT (notes/19.concepts-procedural.cpp):
Sherlock Holmes is 1.81 m and 70 kg; BMI=21.3669
Sherlock Holmes
Unknown is 70 m and 1.81 kg; BMI=0.000369388

*/